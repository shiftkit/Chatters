using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Extensions;

namespace ChatOverlay
{
    public partial class ChatOverlay : Form
    {
        public TcpClient _tcpClient;
        public bool mouseDown;
        public bool clickThrough;
        private StreamReader reader;
        private StreamWriter writer;
        public string channelName;
        //public Dictionary<string, string> EmoteDictionary;

        public ChatOverlay()
        {
            InitializeComponent();
            //LoadEmotes();
            var userOptions = LoadUserOptions();
            LoadSettings(userOptions);
        }

        private UserOptions LoadUserOptions()
        {
            var userSettings = File.ReadAllText(@".\UserSettings.json");
            var convertedSettings = JsonConvert.DeserializeObject<UserOptions>(userSettings);
            return convertedSettings;
        }

        //private void LoadEmotes()
        //{
        //    using (var wc = new WebClient())
        //    {
        //        var emoteJson = wc.DownloadString("https://twitchemotes.com/api_cache/v2/global.json");
        //        //var dynObj = JsonConvert.DeserializeObject(emoteJson);
                
        //        JavaScriptSerializer serializer = new JavaScriptSerializer();
        //        var jsonObj = serializer.Deserialize<ChatEmotes>(emoteJson);
        //        var emotes = jsonObj.emotes;
        //        EmoteDictionary = emotes.Select(s => new {s.Key, Value = s.Value["image_id"]}).ToDictionary(item => item.Key.ToString(), item => item.Value.ToString());
        //    }
        //}

        public void LoadSettings(UserOptions options)
        {
            if (options == null)
                options = new UserOptions();

            if (options.LockOverlay != null)
                clickThrough = options.LockOverlay ?? false;

            if (clickThrough)
            {
                StartTimers();
            }
            else
            {
                timerChat.Enabled = false;
                timerUsers.Enabled = false;
            }

            channelName = options.ChannelName;
            TopMost = true;
            
            lblMoveInfo.Visible = !clickThrough;
            SetClickThrough(options);
            txtUsers.Font = new Font(txtUsers.Font.FontFamily, FontSizeConverter(options.FontSize), options.FontBold ? FontStyle.Bold : FontStyle.Regular);
            txtChat.Font = new Font(txtChat.Font.FontFamily, FontSizeConverter(options.FontSize), options.FontBold ? FontStyle.Bold : FontStyle.Regular);
            txtChat.BackColor = ColorTranslator.FromHtml(options.BgColor);
            txtChat.ForeColor = ColorTranslator.FromHtml(options.FontColor);
            txtUsers.BackColor = ColorTranslator.FromHtml(options.BgColor);
            txtUsers.ForeColor = ColorTranslator.FromHtml(options.FontColor);
            txtUsers.ReadOnly = true;
            txtChat.ReadOnly = true;
            
            tblLayout.ColumnStyles[0].Width = options.ShowUserList ? 25 : 0;
            Reconnect(options.ChannelName);
            ActiveControl = lblActiveControl;
        }

        private void StartTimers()
        {
            timerChat.Enabled = true;
            timerUsers.Enabled = true;

            timerChat.Interval = 1000;
            timerUsers.Interval = 1000;

            if (string.IsNullOrEmpty(txtUsers.Text))
                txtUsers.Text = @"Retrieving viewers...";

            if (string.IsNullOrEmpty(txtChat.Text))
                txtChat.Text = @"Connecting to chat...";
        }

        private int FontSizeConverter(string fontSize)
        {
            if (fontSize == FontSizeEnum.Smallest.ToString())
                return (int)FontSizeEnum.Smallest;

            if (fontSize == FontSizeEnum.Small.ToString())
                return (int)FontSizeEnum.Small;

            if (fontSize == FontSizeEnum.Medium.ToString())
                return (int)FontSizeEnum.Medium;

            if (fontSize == FontSizeEnum.Large.ToString())
                return (int)FontSizeEnum.Large;

            if (fontSize == FontSizeEnum.XL.ToString())
                return (int)FontSizeEnum.XL;

            return (int)FontSizeEnum.Medium;
            
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindowLong32(HandleRef hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindowLongPtr64(HandleRef hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        public static IntPtr GetWindowLong(HandleRef hWnd, int nIndex)
        {
            return IntPtr.Size == 4 ? GetWindowLong32(hWnd, nIndex) : GetWindowLongPtr64(hWnd, nIndex);
        }

        private void Reconnect(string channelName)
        {
            _tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(_tcpClient.GetStream());
            writer = new StreamWriter(_tcpClient.GetStream());
            writer.WriteLine("NICK justinfan12345");
            writer.WriteLine($"JOIN #{channelName}");
            writer.Flush();
        }

        private void timerChat_Tick(object sender, EventArgs e)
        {
            if (!_tcpClient.Connected)
            {
                txtChat.AppendText(@"Reconnecting...");
                Reconnect(channelName);
            }

            if ((_tcpClient.Available > 0 || reader.Peek() >= 0)) //&& reader.EndOfStream)
            {
                var message = reader.ReadLine();
                if (message != null)
                {
                    if (txtChat.Text == @"Connecting to chat...")
                        txtChat.Text = @"Connected.";

                    var iColon = message.IndexOf(":", 1, StringComparison.Ordinal);
                    if (iColon > 0)
                    {
                        var command = message.Substring(1, iColon);
                        if (command.Contains("PRIVMSG"))
                        {
                            var iBang = command.IndexOf("!", StringComparison.Ordinal);
                            if (iBang > 0)
                            {
                                var speaker = command.Substring(0, iBang);
                                var chatMessage = message.Substring(iColon + 1);

                                //foreach (var emote in EmoteDictionary.Keys)
                                //{
                                //    var pattern = "\\b" + emote + "\\b";
                                //    chatMessage = Regex.Replace(chatMessage, pattern, EmoteDictionary[emote]);
                                //}
                                var txtChatLength = txtChat.Text.Length;
                                var startIndex = txtChatLength - 2000;
                                if (txtChatLength > 5000)
                                    txtChat.Text = txtChat.Text.Substring(startIndex);


                                var newChatMsg = $"{speaker}: {chatMessage}"; 

                                //var prevMsg = txtChat.Text;
                                //txtChat.Text = newChatMsg;
                                txtChat.AppendText(Environment.NewLine);
                                txtChat.AppendText(newChatMsg);
                            }
                        }
                    }
                }
            }
            else
            {
                txtChat.AppendText(@"Reconnecting...");
                Reconnect(channelName);
            }
        }

        private void SetClickThrough(UserOptions options)
        {
            FormBorderStyle = FormBorderStyle.None;

            BackColor = clickThrough ? Color.DimGray : ColorTranslator.FromHtml(options.BgColor);
            TransparencyKey = Color.DimGray;
            Opacity = clickThrough ? decimal.ToDouble(options.Opacity/100) : 1;

            if (clickThrough)
            {
                uint initialStyle = GetWindowLong(Handle, -20);
                SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);
            }
            else
            {
                uint initialStyle = GetWindowLong(Handle, -20);
                SetWindowLong(Handle, -20, initialStyle ^0x80000 ^0x20);
            }
        }

        private void timerUsers_Tick(object sender, EventArgs e)
        {
            timerUsers.Interval = 30000;

            using (var wc = new WebClient())
            {
                var json = wc.DownloadString($"https://tmi.twitch.tv/group/user/{channelName}/chatters");
                var jsonToken = JToken.Parse(json);
                var chatters = jsonToken["chatters"];
                var mods = chatters["moderators"];
                var viewers = chatters["viewers"];
                var staff = chatters["staff"];
                var admins = chatters["admins"];

                var viewerList = viewers.Select(v => v.Value<string>()).ToList();
                var modList = mods.Select(m => m.Value<string>()).ToList();
                var staffList = staff.Select(s => s.Value<string>()).ToList();
                var adminList = admins.Select(a => a.Value<string>()).ToList();

                var fullList = adminList.Concat(staffList).Concat(modList).Concat(viewerList);

                txtUsers.Text = string.Join("\r\n", fullList);
            }
        }

        private void tblLayout_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = lblActiveControl;
            mouseDown = true;
        }

        private void tblLayout_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tblLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickThrough || !mouseDown) return;
            var mouseX = MousePosition.X - Width/2;
            var mouseY = MousePosition.Y - Height/2;
            SetDesktopLocation(mouseX, mouseY);
        }
    }
}