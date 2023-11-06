using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SynthiMarkAPI.Domain.Common;
using SynthiMarkAPI.Domain.Entities;
using SynthiMarkAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Context
{
    public class SynthiMarkAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public SynthiMarkAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        
        DbSet<Blog> Blogs { get; set; }
        DbSet<Advertising> Advertisings { get; set; }
        DbSet<AdvertisingType> AdvertisingTypes { get; set; }
        DbSet<PostIdeas> PostIdeas { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Seo> Seos { get; set; }
        DbSet<Video> Videos { get; set; }
        DbSet<VideoIdeas> VideoIdeas { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.Now
                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
