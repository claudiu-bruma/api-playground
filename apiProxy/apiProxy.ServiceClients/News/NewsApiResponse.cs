using System.Collections.Generic;

namespace api.ServiceClients.News
{
    public class NewsApiResponse
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public IEnumerable<NewsDto> articles { get; set; }
    }
}
