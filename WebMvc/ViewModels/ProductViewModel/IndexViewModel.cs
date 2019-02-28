using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.ViewModels.ProductViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<ProductItems> ProductItems { get; set; }
    }
}
