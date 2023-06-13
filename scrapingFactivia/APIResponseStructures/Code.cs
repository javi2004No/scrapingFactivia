using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Code
    {
        public string type { get; set; }
        public string code { get; set; }
        public List<CodeDatum> code_data { get; set; }
        public string description { get; set; }
        public string seoname { get; set; }
        public string value { get; set; }
        public string vrtysux { get; set; }
    }
}
