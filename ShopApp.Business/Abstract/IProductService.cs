using System;
using System.Collections.Generic;
using ShopApp.Entities;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category, int page, int pageSize);
        int GetCountByCategory(string category);
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
    }
}

