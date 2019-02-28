using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPIServices.ViewModel
{
    public class ProductItemsViewModel<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Data { get; private set; }

        public ProductItemsViewModel( IEnumerable<TEntity> data)
        {
            this.Data = data;
        }
    }
}
