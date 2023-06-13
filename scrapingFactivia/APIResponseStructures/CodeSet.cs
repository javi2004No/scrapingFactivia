using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class CodeSet
    {
        public string type { get; set; }
        public string id { get; set; }
        public List<Code> codes { get; set; }
    }
}
