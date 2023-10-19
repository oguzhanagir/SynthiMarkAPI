using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Persistence.Configurations;
using SynthiMarkAPI.Persistence.Context;
using SynthiMarkAPI.Persistence.Repositories;
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
            services.AddDbContext<SynthiMarkAPIDbContext>(options => options.UseSqlServer(DatabaseConfiguration.ConnectiongString));

            services.AddScoped<IAdvertisingReadRepository, AdvertisingReadRepository>();
            services.AddScoped<IAdvertisingWriteRepository, AdvertisingWriteRepository>();
            
            services.AddScoped<IAdvertisingTypeWriteRepository, AdvertisingTypeWriteRepository>();
            services.AddScoped<IAdvertisingTypeReadRepository, AdvertisingTypeReadRepository>();
            
            services.AddScoped<IBlogReadRepository, BlogReadRepository>();
            services.AddScoped<IBlogWriteRepository, BlogWriteRepository>();
            
            services.AddScoped<IPostIdeasWriteRepository, PostIdeasWriteRepository>();
            services.AddScoped<IPostIdeasReadRepository, PostIdeasReadRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<ISeoWriteRepository, SeoWriteRepository>();
            services.AddScoped<ISeoReadRepository, SeoReadRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IVideoWriteRepository, VideoWriteRepository>();
            services.AddScoped<IVideoReadRepository, VideoReadRepository>();

            services.AddScoped<IVideoIdeasReadRepository, VideoIdeasReadRepository>();
            services.AddScoped<IVideoIdeasWriteRepository, VideoIdeasWriteRepository>();



        } 
    }
}
