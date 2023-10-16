using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SynthiMarkAPI.Persistence.Configurations;
using SynthiMarkAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SynthiMarkAPIDbContext>
    {
        public SynthiMarkAPIDbContext CreateDbContext(string[] args)
        {

            DbContextOptionsBuilder<SynthiMarkAPIDbContext> dbContextOptionsBuilder = new();

            dbContextOptionsBuilder.UseNpgsql(DatabaseConfiguration.ConnectiongString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}
