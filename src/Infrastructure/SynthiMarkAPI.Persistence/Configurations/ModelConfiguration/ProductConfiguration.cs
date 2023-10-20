using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Configurations.ModelConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.SubDescription).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Features).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
