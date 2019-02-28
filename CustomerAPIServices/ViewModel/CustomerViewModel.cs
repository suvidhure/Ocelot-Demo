using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPIServices.ViewModel
{
    public class CustomerViewModel<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Data { get; private set; }

        public CustomerViewModel(IEnumerable<TEntity> data)
        {
            this.Data = data;
        }
    }
}
