﻿using ShopApp.Business.Abstract;
using ShopApp.DataLayer.Abstract;
using ShopApp.DataLayer.Concrete.EfCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
           return _productDal.GetAll().ToList();
        }

        public Product GetById(int id)
        {
           return _productDal.GetByID(id);
        }

        public List<Product> GetPopularProducts()
        {
            return _productDal.GetAll().ToList();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
