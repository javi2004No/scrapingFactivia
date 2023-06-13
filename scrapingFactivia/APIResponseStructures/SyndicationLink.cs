using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class SyndicationLink
    {
        public string type { get; set; }
        public string uri { get; set; }
        public bool external { get; set; }
        public List<object> content { get; set; }
    }
}
