using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Interface;

public interface IRepository<T> where T: class
{
    IQueryable<T> Where(Expression<Func<T, bool>> predicate);

}

//Base Repository for CRUD Operations
public interface ICrudRepository<T> : IRepository<T> where T : class
{
    //EntityToContext
    T Add (T entity);
    Task<T> AddAsync(T entity);
    T Update (T entity);
    T Delete (T entity);
    bool DeleteBy (int id);
}

