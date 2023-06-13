using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class RelatedLink
    {
        public string type { get; set; }
        public bool essential { get; set; }
        public Content content { get; set; }
        public string id { get; set; }
    }
}
