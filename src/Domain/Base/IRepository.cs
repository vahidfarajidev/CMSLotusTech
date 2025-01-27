using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<T?> GetByIdAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T model, CancellationToken cancellationToken);
        Task UpdateAsync(T model);
        Task DeleteAsync(Guid id);
    }
}
