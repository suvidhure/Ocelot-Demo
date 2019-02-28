using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CustomerAPIServices.Model;
using CustomerAPIServices.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Services.CustomerAPIServices.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]

        [ProducesResponseType(typeof(CustomerViewModel<Customer>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IEnumerable<Customer>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            Customer _customer;
            List<Customer> _customerList = new List<Customer>();
            _customer = new Customer
            {
                Id = 1,
                Name = "Customer 1"
            };
            _customerList.Add(_customer);
            _customer = new Customer
            {
                Id = 2,
                Name = "Customer 2"
            };
            _customerList.Add(_customer);

            var model = new CustomerViewModel<Customer>(_customerList);
            return Ok(model);
        }
    }
}