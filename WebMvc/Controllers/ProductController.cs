using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Services;
using WebMvc.ViewModels.ProductViewModel;

namespace WebMvc.Controllers
{
    public class ProductController : Controller
    {
        private IProductServices _productSvc;

        public ProductController(IProductServices productSvc)   => 
            _productSvc = productSvc;

        public async Task<IActionResult> Index()
        {
            var product = await _productSvc.GetProductsAsync();
            var vm = new IndexViewModel()
            {
                ProductItems = product.Data,
                
            };
            return View(vm);
        }
    }
}