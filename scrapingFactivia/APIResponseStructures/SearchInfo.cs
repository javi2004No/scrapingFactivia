using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class SearchInfo
    {
        public string canonical_query { get; set; }
        public string highlight_text { get; set; }
        public string search_context { get; set; }
    }
}
