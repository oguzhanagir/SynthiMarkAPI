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
    public class AdvertisingConfiguration : IEntityTypeConfiguration<Advertising>
    {
        public void Configure(EntityTypeBuilder<Advertising> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.AdvertisingType).IsRequired().HasMaxLength(250);
        }
    }
}
