using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

namespace ChatOverlay
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            var userSettings = File.ReadAllText(@".\UserSettings.json");
            var convertedSettings = JsonConvert.DeserializeObject<UserOptions>(userSettings);
            boxColorFont.BackColor = ColorTranslator.FromHtml(convertedSettings.FontColor);
            boxColorBG.BackColor = ColorTranslator.FromHtml(convertedSettings.BgColor);
            txtChannel.Text = convertedSettings.ChannelName;
            ddlFont.SelectedItem = convertedSettings.FontSize;
            chkShowUsers.Checked = convertedSettings.ShowUserList;
            numOpacity.Value = convertedSettings.Opacity;
        }

        private ChatOverlay GetChatOverlayInstance()
        {
            var formList = Application.OpenForms.OfType<ChatOverlay>();
            var chatOverlays = formList as IList<ChatOverlay> ?? formList.ToList();
           
            return chatOverlays.Any() ? chatOverlays.FirstOrDefault() : null;
        }



        private void btnLaunchOverlay_Click(object sender, EventArgs e)
        {
            SaveOptions();
            btnLaunchOverlay.Text = @"Reload Overlay";
            btnLockOverlay.Enabled = true;
            btnCloseOverlay.Enabled = true;
            var overlay = GetChatOverlayInstance();
            var options = GetOptions();
            SetUpOverlay(overlay, options);
        }

        private void SetUpOverlay(ChatOverlay overlay, UserOptions options)
        {
            if (overlay == null)
            {
                overlay = new ChatOverlay();
                overlay.LoadSettings(options);
                overlay.Show();
            }
            else
            {
                overlay.LoadSettings(options);
            }
        }

        private UserOptions GetOptions()
        {
            var userSettings = File.ReadAllText(@".\UserSettings.json");
            var convertedSettings = JsonConvert.DeserializeObject<UserOptions>(userSettings);
            return convertedSettings;
        }

        private void btnCloseOverlay_Click(object sender, EventArgs e)
        {
            var overlay = GetChatOverlayInstance();
            ResetButtons();
            overlay?.Close();
        }

        private void btnLockOverlay_Click(object sender, EventArgs e)
        {
            var overlay = GetChatOverlayInstance();
            var options = GetOptions();

            if (btnLockOverlay.Text == @"Lock Overlay")
            {
                options.LockOverlay = true;
                btnLockOverlay.Text = @"Unlock Overlay";
            }
            else
            {
                options.FontColor = options.BgColor;
                options.LockOverlay = false;
                btnLockOverlay.Text = @"Lock Overlay";
            }

            SetUpOverlay(overlay, options);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorFont.ShowDialog() == DialogResult.OK)
            {
                boxColorFont.BackColor = colorFont.Color;
            }
        }

        private void SaveOptions()
        {
            var options = new UserOptions();
            options.FontColor = ColorTranslator.ToHtml(boxColorFont.BackColor);
            options.BgColor = ColorTranslator.ToHtml(boxColorBG.BackColor);
            options.ChannelName = txtChannel.Text;
            options.FontSize = ddlFont.Text;
            options.ShowUserList = chkShowUsers.Checked;
            options.FontBold = chkBold.Checked;
            options.Opacity = numOpacity.Value;

            var json = JsonConvert.SerializeObject(options);
            using (StreamWriter sw = new StreamWriter(@".\UserSettings.json"))
            {
                sw.Write(json);
                sw.Close();
            }
        }

        private void ResetButtons()
        {
            btnLockOverlay.Enabled = false;
            btnCloseOverlay.Enabled = false;
            btnLockOverlay.Text = @"Lock Overlay";
            btnLaunchOverlay.Text = @"Launch Overlay";
        }

        private void boxColorBG_Click(object sender, EventArgs e)
        {
            if (colorBG.ShowDialog() == DialogResult.OK)
            {
                boxColorBG.BackColor = colorBG.Color;
            }
        }
    }
}