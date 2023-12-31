﻿using Microsoft.EntityFrameworkCore;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Domain.Common;
using SynthiMarkAPI.Domain.Entities;
using SynthiMarkAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SynthiMarkAPIDbContext _context;

        public ReadRepository(SynthiMarkAPIDbContext context)
        {
            _context = context;
        }


        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll(Guid userId,bool tracking = true)
        {
            var query = Table.AsQueryable().Where(x => x.UserForeg.Id == userId);

            if (!tracking)
                query = query.AsNoTracking();

            return query;
        }
                    
        public IQueryable<T> GetWhere(Guid userId, Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(x => x.UserForeg.Id == userId).Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(Guid userId, string id, bool tracking = true)
        {
            var query = Table.AsQueryable().Where(x => x.UserForeg.Id == userId);
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

            
        }

        public async Task<T> GetSingleAsync(Guid userId, Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable().Where(x => x.UserForeg.Id == userId);
            if(!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }
    }
}
