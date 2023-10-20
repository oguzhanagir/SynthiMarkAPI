using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SynthiMarkAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Persistence.Configurations.ModelConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Mail).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(15);

        }
    }
}
