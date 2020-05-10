using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiProxy.Models
{
    public class NewsSearchRequest
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
