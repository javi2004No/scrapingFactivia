using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Attributes
    {
        public List<Author> authors { get; set; }
        public string bitly_url { get; set; }
        public Byline byline { get; set; }
        public List<string> categories { get; set; }
        public string content_status { get; set; }
        public Copyright copyright { get; set; }
        public string display_name { get; set; }
        public Headline headline { get; set; }
        public string id { get; set; }
        public string id_ref { get; set; }
        public Language language { get; set; }
        public DateTime modification_time { get; set; }
        public string privileges { get; set; }
        public DateTime publication_time { get; set; }
        public string section { get; set; }
        public string seo_id { get; set; }
        public string seo_id_ref { get; set; }
        public Snippet snippet { get; set; }
        public List<Source> sources { get; set; }
        public string sub_section { get; set; }
        public Summaries summaries { get; set; }
        public List<Ticker> tickers { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
