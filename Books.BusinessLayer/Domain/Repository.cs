﻿using Books.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Books.BusinessLayer.Domain
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private DbContext _context;
        private DbSet<T> _db;

        public Repository(BookContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }

        public IEnumerable<T> All()
        {
            return _db.ToList();
        }

        public void Create(T entity)
        {
            _db.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _db.AsNoTracking().Where(predicate).ToList();
        }
    }
}