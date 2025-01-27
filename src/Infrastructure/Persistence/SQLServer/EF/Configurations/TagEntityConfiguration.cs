using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Persistence.SQLServer.EF.Entities;

namespace Infrastructure.Persistence.SQLServer.EF.Configurations
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<TagEntity>
    {
        public void Configure(EntityTypeBuilder<TagEntity> builder)
        {
            builder.ToTable("Tag");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.TagName)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(dc => dc.IsActive)
                   .IsRequired();
        }
    }

}
