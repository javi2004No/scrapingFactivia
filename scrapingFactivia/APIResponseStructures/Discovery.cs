using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Discovery
    {
        public List<Code> codes { get; set; }
        public Time time { get; set; }
        public List<Keyword> keywords { get; set; }
        public List<Category> category { get; set; }
    }
}
