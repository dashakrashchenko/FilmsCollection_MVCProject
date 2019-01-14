﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FilmsCollectionProject.DAL
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> pred);

        void Add(T t);
        void Remove(T t);
    }
}
