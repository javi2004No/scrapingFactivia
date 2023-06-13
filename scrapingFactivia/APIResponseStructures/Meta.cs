using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.Structures
{
    internal class Meta
    {
        public List<string> keywords { get; set; }
        public int count { get; set; }
        public int total_count { get; set; }
        public Offset offset { get; set; }
        public Discovery discovery { get; set; }
        public List<DuplicateHeadline> duplicate_headlines { get; set; }
        public SearchInfo search_info { get; set; }
        public CollectionInfo collection_info { get; set; }
        public int document_vector { get; set; }
        public List<CodeSet> code_sets { get; set; }
        public Emphasis emphasis { get; set; }
        public List<GeoRelevance> geo_relevance { get; set; }
        public Metrics metrics { get; set; }
        public int rank { get; set; }
        public List<TruncationRule> truncation_rules { get; set; }
    }
}
