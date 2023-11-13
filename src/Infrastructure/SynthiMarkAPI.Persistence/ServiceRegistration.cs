using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SynthiMarkAPI.Application.Abstractions.Services;
using SynthiMarkAPI.Application.Abstractions.Services.Authentications;
using SynthiMarkAPI.Application.Interfaces.Repositories;
using SynthiMarkAPI.Domain.Entities.Identity;
using SynthiMarkAPI.Persistence.Configurations;
using SynthiMarkAPI.Persistence.Context;
using SynthiMarkAPI.Persistence.Repositories;
using SynthiMarkAPI.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SynthiMarkAPIDbContext>(options => options.UseSqlServer(DatabaseConfiguration.ConnectiongString));

            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<SynthiMarkAPIDbContext>();

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

            services.AddScoped<IVideoWriteRepository, VideoWriteRepository>();
            services.AddScoped<IVideoReadRepository, VideoReadRepository>();

            services.AddScoped<IVideoIdeasReadRepository, VideoIdeasReadRepository>();
            services.AddScoped<IVideoIdeasWriteRepository, VideoIdeasWriteRepository>();

            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IAuthService,AuthService>();
            services.AddScoped<IExternalAuthentication,AuthService>();
            services.AddScoped<IInternalAuthentication,AuthService>();


        } 
    }
}
