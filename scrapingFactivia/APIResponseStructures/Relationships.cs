using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Relationships
    {
        public RelatedLinks related_links { get; set; }
        public List<SyndicationLink> syndication_links { get; set; }
    }
}
