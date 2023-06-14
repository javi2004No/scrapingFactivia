using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Root
    {
        public Links links { get; set; }
        public Meta meta { get; set; }
        public List<Data> data { get; set; }
        public List<Included> included { get; set; }
    }
}
