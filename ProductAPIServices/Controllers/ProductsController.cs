using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPIServices.Model;
using ProductAPIServices.ViewModel;

namespace Services.ProductAPIServices.Controllers
{
    [Route("api/[controller]")]
    
    public class ProductsController : Controller
    {
        [HttpGet]

        [ProducesResponseType(typeof(ProductItemsViewModel<ProductItem>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<ProductItem>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            ProductItem _productItem;
            List<ProductItem> _productList = new List<ProductItem>();
            _productItem = new ProductItem
            {
                Id = 1,
                Name = "Samsung Pro"
            };
            _productList.Add(_productItem);
            _productItem = new ProductItem
            {
                Id = 2,
                Name = "iPhone 5"
            };
            _productList.Add(_productItem);

            var model = new ProductItemsViewModel<ProductItem>(_productList);
            return Ok(model);
        }
    }
}