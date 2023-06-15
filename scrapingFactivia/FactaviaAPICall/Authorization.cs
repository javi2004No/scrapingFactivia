using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace scrapingFactivia.FactaviaAPICall
{
    internal class Authorization
    {
        public Authorization(string ClientID)
        {
            clientID = ClientID;
        }
        private string clientID;
        
        private async Task<APIResponseStructures.TokenV1> getFirstToken(string Username, string Password)
        {
            APIResponseStructures.TokenV1 token = null;

            var options = new RestClientOptions("https://accounts.dowjones.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);

            var request = new RestRequest("/oauth2/v1/token", Method.Post);

            request.AddParameter("client_id", clientID);

            request.AddParameter("username", Username);

            request.AddParameter("password", Password);

            request.AddParameter("scope", "openid pib");

            request.AddParameter("grant_type", "password");

            request.AddParameter("connection", "service-account");

            RestResponse aPIResponse = await client.ExecuteAsync(request);

            if (aPIResponse.IsSuccessStatusCode)
            {
                token = new APIResponseStructures.TokenV1();
                token = JsonSerializer.Deserialize<APIResponseStructures.TokenV1>(aPIResponse.Content);
                Console.WriteLine("First Token Successfull");
            }
            else
            {
                Console.WriteLine(aPIResponse.Content.ToString());
                Console.WriteLine("First Token Error");
            }

            return token;
        }

        public async Task<APIResponseStructures.TokenV2> getAuthourization(string Username, string Password)
        {
            APIResponseStructures.TokenV2 token = null;

            var options = new RestClientOptions("https://accounts.dowjones.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);

            var request = new RestRequest("/oauth2/v1/token", Method.Post);

            Task<APIResponseStructures.TokenV1> root = getFirstToken(Username, Password);

            APIResponseStructures.TokenV1 root2 = root.Result;

            if (root2 != null)
            {


                request.AddParameter("client_id", clientID);

                request.AddParameter("assertion", root2.id_token);

                request.AddParameter("scope", "openid pib");

                request.AddParameter("grant_type", "urn:ietf:params:oauth:grant-type:jwt-bearer");

                RestResponse aPIResponse = await client.ExecuteAsync(request);

                if (aPIResponse.IsSuccessStatusCode)
                {
                    token = new APIResponseStructures.TokenV2();
                    token = JsonSerializer.Deserialize<APIResponseStructures.TokenV2>(aPIResponse.Content);
                    Console.WriteLine("Second Token Succesfull");
                }
                else
                {
                    Console.WriteLine(aPIResponse.Content.ToString());
                    Console.WriteLine("Second Token Error");
                }
            }
            
            return token;
        }

    }
}
