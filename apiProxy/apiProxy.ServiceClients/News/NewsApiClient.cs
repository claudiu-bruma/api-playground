using System;
using System.Net.Http;
using System.Threading.Tasks; 
using api.ServiceClients.News.Config;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace api.ServiceClients.News
{
    public class NewsApiClient
    {
        public HttpClient Client { get; }
        public NewsApiServiceConfig NewsApiServiceConfig { get; set; }
        public NewsApiClient(HttpClient client, IOptions<NewsApiServiceConfig> config)
        {
            NewsApiServiceConfig = config.Value;
            client.BaseAddress = new Uri( NewsApiServiceConfig.Url);
            Client = client;
        }
      
        public async Task<NewsApiResponse> Get(NewsSearchRequest request)
        {
            var response = await Client.GetAsync(
             $"v2/everything?q={request.SearchTerm}&apiKey={NewsApiServiceConfig.ApiKey}");

            response.EnsureSuccessStatusCode();

            var responseStream = await response.Content.ReadAsStringAsync();
            var myJsonObject = JsonConvert.DeserializeObject<NewsApiResponse>(responseStream);
            return myJsonObject;
        }
    }
}

