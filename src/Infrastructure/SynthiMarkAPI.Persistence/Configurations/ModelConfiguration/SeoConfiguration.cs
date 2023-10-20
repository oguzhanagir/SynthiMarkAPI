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
    public class SeoConfiguration : IEntityTypeConfiguration<Seo>
    {
        public void Configure(EntityTypeBuilder<Seo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.AuthorInfo).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
        }
    }
}
