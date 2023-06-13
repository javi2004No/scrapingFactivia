using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Included
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Links links { get; set; }
    }
}
