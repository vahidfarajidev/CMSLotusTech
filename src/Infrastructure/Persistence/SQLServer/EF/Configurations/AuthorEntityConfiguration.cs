using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Configurations
{
    public class AuthorEntityConfiguration : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.ToTable("Authors");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.FullName)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(a => a.Email)
                     .HasMaxLength(256);

            builder.Property(a => a.Comment)
                     .HasMaxLength(512);
        }

    }
}
