using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Abstractions.IRepository
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> Filter(Expression<Func<T,bool>> expression);
        Task<bool> IsExists(Expression<Func<T,bool>> expression);
        Task<T?> GetByIdAsync(Guid id);
        Task<int> AddAsync(T model);
        Task<int> DeleteAsync(T model);
        Task<int> DeleteAsync(Guid id);
        Task<int> UpdateAsync(T model);
        Task<int> InsertRange(List<T> models);
        Task<int> DeleteRangeAsync(List<Guid> ids);
        Task<int> DeleteRangeAsync(List<T> models);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
    }
}
