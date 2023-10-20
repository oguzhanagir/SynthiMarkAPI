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
    public class PostIdeasConfiguration : IEntityTypeConfiguration<PostIdeas>
    {
        public void Configure(EntityTypeBuilder<PostIdeas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(500);
        }
    }
}
