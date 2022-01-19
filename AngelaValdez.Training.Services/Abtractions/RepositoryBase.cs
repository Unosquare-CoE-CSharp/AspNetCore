﻿using AngelaValdez.Training.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AngelaValdez.Training.Services.Abtractions
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(T entity)
        {
            this._applicationDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this._applicationDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _applicationDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return this._applicationDbContext.Set<T>().Where(predicate).AsNoTracking();
        }

        public void Update(T entity)
        {
            this._applicationDbContext.Set<T>().Update(entity);
        }
    }
}
