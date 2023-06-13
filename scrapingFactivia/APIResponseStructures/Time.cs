using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Time
    {
        public string type { get; set; }
        public List<TimeDatum> time_data { get; set; }
    }
}
