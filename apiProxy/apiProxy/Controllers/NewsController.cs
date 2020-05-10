using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ServiceClients.News;
using api.ServiceClients.News.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiProxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        public NewsApiClient NewsApiClient { get; set; }
        public NewsController(NewsApiClient newsApiClient)
        {
            NewsApiClient = newsApiClient;
        }

        [HttpGet()]
        public async Task<NewsApiResponse> Get([FromQuery]NewsSearchRequest request)
        {
            return await NewsApiClient.Get(request);
        }
    }
}