using ShopApp.DataLayer.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products= new List<Product>()
            {
                new Product() { Id = 1, Name="Samsung S9",ImageUrl="1.jpg",Price=25000,Stock=5200},
                new Product() { Id = 2, Name="Samsung 52A",ImageUrl="3.jpg",Price=19800,Stock=5200},
            };
           return products;
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetPopullerProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        List<Product> IRepository<Product>.GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductDal.GetPopullerProducts()
        {
            throw new NotImplementedException();
        }
    }
}
