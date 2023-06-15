using System;
using System.Collections.Generic;
using System.Text;

namespace scrapingFactivia.APIResponseStructures
{
    internal class TokenV1
    {
        public string id_token { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }

    }
}
