using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SynthiMarkAPI.Persistence.Configurations;
using SynthiMarkAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<SynthiMarkAPIDbContext>(options => options.UseNpgsql(DatabaseConfiguration.ConnectiongString);
        } 
    }
}
