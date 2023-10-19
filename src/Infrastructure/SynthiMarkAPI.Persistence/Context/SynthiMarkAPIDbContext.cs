using Microsoft.EntityFrameworkCore;
using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Context
{
    public class SynthiMarkAPIDbContext : DbContext
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
        DbSet<User> Users { get; set; }
        DbSet<Video> Videos { get; set; }
        DbSet<VideoIdeas> VideoIdeas { get; set; }

    }
}
