using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Avatar
    {
        public string type { get; set; }
        public List<Caption> caption { get; set; }
        public string credit { get; set; }
        public List<Size> size { get; set; }
    }
}
