using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ShopApp.Entities;
namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        List<Product> GetProductsByCategory(string category, int page, int pageSize);
        Product GetProductDetails(int id);
        int GetCountByCategory(string category);
    }
}

