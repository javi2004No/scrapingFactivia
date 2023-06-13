using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Author
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string full_name { get; set; }
        public Avatar avatar { get; set; }
    }
}
