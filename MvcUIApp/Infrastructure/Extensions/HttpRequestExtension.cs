using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIApp.Infrastructure.Extensions
{
    public static class HttpRequestExtension
    {
        public static string PathAndQuery(this HttpRequest request)
        {
            return request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString(); 
        }
    }
}