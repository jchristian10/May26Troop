using System;
using System.Linq;
using System.Collections.Generic;
namespace TeamsMVC.Repositories
{
    public interface IGenericRepository : IDisposable
    {
        void Add<T>(T entityToCreate) where T : class;
        
        void Delete<T>(params object[] keyValues) where T : class;
        
        T Find<T>(params object[] keyValues) where T : class;
        
        IQueryable<T> Query<T>() where T : class;
        
        void SaveChanges();
        
        IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters);
    }
}
