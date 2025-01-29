using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Configurations
{
    public class DataCategoryEntityConfiguration : IEntityTypeConfiguration<DataCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<DataCategoryEntity> builder)
        {
            builder.ToTable("DataCategories");

            builder.HasKey(dc => dc.Id);

            builder.Property(dc => dc.DataCategoryName)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(dc => dc.IsActive)
                   .IsRequired();
        }
    }

}
