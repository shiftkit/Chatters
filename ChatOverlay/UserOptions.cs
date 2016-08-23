using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOverlay
{
    public class UserOptions
    {
        public string ChannelName { get; set; }
        public string FontSize { get; set; }
        public bool FontBold { get; set; }
        public string BgColor { get; set; }
        public string FontColor { get; set; }
        public decimal Opacity { get; set; }
        public bool ShowUserList { get; set; }
        public bool? LockOverlay { get; set; }
        public string WindowPosition { get; set; }
        public string WindowSize { get; set; }
    }
}