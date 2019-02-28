using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebMvc.Infrastructure;
using WebMvc.Services;
using WebMvc.ViewModels;

namespace WebMvc.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IOptions<AppSettings> _settings;
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public ProductServices(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            _settings = settings;
            _httpClient = httpClient;
            _remoteServiceBaseUrl= $"{_settings.Value.ProductUrl}";
        }
        public async Task<Product> GetProductsAsync()
        {
            var uri = API.Product.GetProducts(_remoteServiceBaseUrl);

            var responseString = await _httpClient.GetStringAsync(uri);

            var product = JsonConvert.DeserializeObject<Product>(responseString);

            return product;
        }
    }
}
