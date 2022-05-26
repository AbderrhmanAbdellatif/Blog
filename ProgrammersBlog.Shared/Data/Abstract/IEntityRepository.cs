using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Abstract
{
    public interface IEntityRepository <T> where T : class,IEntity,new()
    {
     Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>> [] includeProperties);  //var kullanci =repository.GetAsync(k=>k.personel.maj==15)
     Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null,
         params Expression<Func<T, object>>[] includeProperties);// tum kategorleri getirmek istiyoryuz 
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null);
    }
}
