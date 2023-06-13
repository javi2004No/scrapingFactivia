using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Content
    {
        public string type { get; set; }
        public bool essential { get; set; }
        public string display { get; set; }
        public string field_id { get; set; }
        public List<object> content { get; set; }
        public string uri { get; set; }
        public bool external { get; set; }
        public List<Caption> caption { get; set; }
        public string credit { get; set; }
        public List<Size> size { get; set; }
    }
}
