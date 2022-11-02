using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ShopApp.Entities;
namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        IEnumerable<Product> GetPopulerProducts();
        Product GetProductDetails(int id);
    }
}

