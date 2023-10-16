using SynthiMarkAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> Remove(T entity);
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(T entity);
    }
}
