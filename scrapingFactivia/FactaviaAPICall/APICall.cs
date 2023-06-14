using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace scrapingFactivia.FactaviaAPICall
{
    internal class APICall
    {
        public async Task<Structures.Root> Search(string searchTerm, string authorizeToken)
        {
            Structures.Root response = null;

            var options = new RestClientOptions("https://api.dowjones.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);

            var request = new RestRequest("/content/search", Method.Get);

            request.AddParameter("filter.search_string", searchTerm);

            request.AddHeader("Authorization", authorizeToken);

            RestResponse aPIResponse = await client.ExecuteAsync(request);


            if (aPIResponse.IsSuccessStatusCode)
            {
                response = new Structures.Root();
                response = JsonSerializer.Deserialize<Structures.Root>(aPIResponse.Content);
                Console.WriteLine(aPIResponse.Content);
            }
            else
            {
                Console.WriteLine(aPIResponse.Content);
            }
            
            return response;
        }
    }
}
