using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopulerProducts()
        {
            throw new NotImplementedException();
        }
    }
}

    