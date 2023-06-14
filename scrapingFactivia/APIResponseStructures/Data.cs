using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Data
    {
        public string type { get; set; }
        public string id { get; set; }
        public Attributes attributes { get; set; }
        public Meta meta { get; set; }
        public Links links { get; set; }
        public Relationships relationships { get; set; }
    }
}
