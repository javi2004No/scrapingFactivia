using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class DuplicateHeadline
    {
        public int headline_count { get; set; }
        public List<HeadlineRef> headline_refs { get; set; }
    }
}
