using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Headline
    {
        public List<Flashline> flashline { get; set; }
        public List<Main> main { get; set; }
        public List<Deck> deck { get; set; }
    }
}
