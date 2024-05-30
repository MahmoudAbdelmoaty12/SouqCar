using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Application.Contract
{
    public interface IRepository<TEntity,TId>
    {
        Task<TEntity> CreatAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> GetByNameAsync(string name);
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<int> SaveChangesAsync();
       
    }
}
