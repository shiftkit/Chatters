using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOverlay
{
    public class ChatEmotes
    {
        public Dictionary<string, string> meta { get; set; }
        public Dictionary<string, string> template { get; set; }
        public Dictionary<string, Dictionary<string, string>> emotes { get; set; }
        //public string EmoteName { get; set; }
        //public string ImageId { get; set; }
    }
}
