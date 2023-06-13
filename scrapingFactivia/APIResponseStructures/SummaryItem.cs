using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class SummaryItem
    {
        public string variant { get; set; }
        public string destination_type { get; set; }
        public List<string> pages { get; set; }
        public Headline headline { get; set; }
        public Body body { get; set; }
        public List<RelatedLink> related_links { get; set; }
    }
}
