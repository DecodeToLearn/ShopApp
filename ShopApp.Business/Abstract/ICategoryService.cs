using System;
using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();

        void Create(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
    }
}

