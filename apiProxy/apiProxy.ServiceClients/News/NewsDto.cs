using System;
using System.Net.NetworkInformation;
using System.Text;

namespace api.ServiceClients.News
{
    public class NewsDto
    {
        public NewsApiSourceDto source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Uri url { get; set; }

        public Uri urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }
        public string status { get; set; }
    }
}
