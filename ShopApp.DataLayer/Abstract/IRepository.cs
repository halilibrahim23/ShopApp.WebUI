﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Abstract
{
    public interface IRepository<T>
    {
        T GetByID(int id);
        T GetOne(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
