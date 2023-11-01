using SynthiMarkAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(Guid userId, bool tracking = true);
        IQueryable<T> GetWhere(Guid userId, Expression<Func<T,bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Guid userId, Expression<Func<T,bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(Guid userId, string id, bool tracking = true);
    }
}
