using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class HeadlineRef
    {
        public int index { get; set; }
        public string @ref { get; set; }
        public List<Duplicate> duplicates { get; set; }
    }
}
