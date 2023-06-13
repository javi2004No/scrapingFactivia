using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Size
    {
        public string type { get; set; }
        public string id_ref { get; set; }
        public bool is_responsive { get; set; }
        public string slug { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int bytes { get; set; }
        public string reference { get; set; }
        public string image_type { get; set; }
        public string mime_type { get; set; }
        public string sub_type { get; set; }
        public string uri { get; set; }
    }
}
