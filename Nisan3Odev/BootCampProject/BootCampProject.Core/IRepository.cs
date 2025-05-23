﻿using BootCampProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BootCampProject.Core.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

