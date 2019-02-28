using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public static class API
    {
        public static class Product
        {
            public static string GetProducts(string baseUri) => $"{baseUri}";

            public static string GetCustomers(string baseUri) => $"{baseUri}";

        }
    }
}
