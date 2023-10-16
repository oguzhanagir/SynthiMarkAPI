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

        DbSet<Customer> Customers { get; set; }
        DbSet<Blog> Blogs { get; set; }

    }
}
