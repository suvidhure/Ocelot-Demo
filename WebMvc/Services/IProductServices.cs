using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.ViewModels;

namespace WebMvc.Services
{
    public interface IProductServices
    {
         Task<Product> GetProductsAsync();
    }
}
