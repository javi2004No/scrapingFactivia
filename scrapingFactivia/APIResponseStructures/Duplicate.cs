using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Duplicate
    {
        public int duplicate_count { get; set; }
        public List<DuplicateRef> duplicate_ref { get; set; }
    }
}
