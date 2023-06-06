﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository.IRepository
{
    internal interface IRepository<T> where T : class
    {
        //T - Lendet
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void DeleteRange(IEnumerable<T> entity);
    }
}