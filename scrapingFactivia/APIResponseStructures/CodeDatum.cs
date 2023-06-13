using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class CodeDatum
    {
        public string code { get; set; }
        public string description { get; set; }
        public int hit_count { get; set; }
        public string @ref { get; set; }
    }
}
