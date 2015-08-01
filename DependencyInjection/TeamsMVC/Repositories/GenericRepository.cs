using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using TeamMVC.Data;

namespace TeamsMVC.Repositories
{
    public class GenericRepository : TeamsMVC.Repositories.IGenericRepository
    {
        private DbContext _db;

        public GenericRepository(DbContext db)
        {
            _db = db;
        }

        public IQueryable<T> Query<T>() where T : class  //a generic query method
        {
            return _db.Set<T>().AsQueryable();
        }

        //THIS IS THE SAME AS ABOVE BUT WITHOUT THE GENERIC TYPING.  DO NOT DO THIS!
        //
        //public IQueryable Query(string entityTypeName)
        //{
        //    var entityType = Type.GetType(entityTypeName);
        //    return _db.Set(entityType).AsQueryable();
        //}

        public T Find<T>(params object[] keyValues) where T : class  //a generic Find method
        {
            return _db.Set<T>().Find(keyValues);
        }

        public void Add<T>(T entityToCreate) where T : class //This is a generic Add method
        {
            _db.Set<T>().Add(entityToCreate);
        }

        public void Delete<T>(params object[] keyValues) where T: class //This is a generic Delete Method
        {
            var entity = this.Find<T>(keyValues);
            _db.Set<T>().Remove(entity);

        }

        public void SaveChanges()//This is a method to try to save the changes made to the database
        {
            try
            {
                _db.SaveChanges();
            }
            catch (DbEntityValidationException dbVal)
            {
                var firstError = dbVal.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }

        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)  //converts sql statemtnts to be useful to populate an object
        {
            return _db.Database.SqlQuery<T>(sql, parameters);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}