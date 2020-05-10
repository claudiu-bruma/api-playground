using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ServiceClients.News.Config
{
    public class NewsSearchRequest
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Language { get; set; }
        public string SortBy { get; set; }
        public string Domains { get; set; }

        public string ToString()
        {
            var stringAccumulator = $"?q={SearchTerm}&pageSize={PageSize}&page={PageNumber}&language={Language}";
            if (!string.IsNullOrWhiteSpace(SortBy))
            {
                stringAccumulator += $"sortBy={SortBy}";
            }
            if (!string.IsNullOrWhiteSpace(Domains))
            {
                stringAccumulator += $"domains={Domains}";
            }
            return stringAccumulator;
        }
    }
}
