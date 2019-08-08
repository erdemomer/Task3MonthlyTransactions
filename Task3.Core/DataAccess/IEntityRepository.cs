using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Task3.Core.Entities;

namespace Task3.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>>filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
