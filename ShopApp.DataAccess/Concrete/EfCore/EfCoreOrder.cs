using System;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreOrder : EfCoreGenericRepository<Order, ShopContext>, IOrderDal
    {
    }
}

