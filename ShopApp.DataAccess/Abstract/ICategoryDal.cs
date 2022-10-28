using System;
using ShopApp.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
    }
}

