using ShopApp.DataLayer.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Concrete.EfCore
{
    public class EfCoreCategoryDal :EfCoreGenericRepository<Category, ShopContext>, ICategoryDal
    {
        
    }
}
