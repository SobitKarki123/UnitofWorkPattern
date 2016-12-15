using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using UnitofWorkPatternRepositoryPattern.Models;
using UnitofWorkPatternRepositoryPattern.Repository.Contacts;

namespace UnitofWorkPatternRepositoryPattern.Repository
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private ContactContext entities = null;
        IObjectSet<T> _objectSet;

        public GenericRepository(ContactContext _entities)
        {
            entities = _entities;
          //  _objectSet = entities.CreateObjectSet<T>();
            
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _objectSet.Where(predicate);
            }

            return _objectSet.AsEnumerable();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _objectSet.First(predicate);
        }

        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
        }
    }
}