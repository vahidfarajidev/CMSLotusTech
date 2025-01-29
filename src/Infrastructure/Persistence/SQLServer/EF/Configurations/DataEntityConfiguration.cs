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
    public class DataEntityConfiguration : IEntityTypeConfiguration<DataEntity>
    {
        public void Configure(EntityTypeBuilder<DataEntity> builder)
        {
            builder.ToTable("Datas");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.DataTitle)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(d => d.DataSummary)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(d => d.DataBody)
                   .IsRequired()
                   .HasMaxLength(512);

            builder.Property(d => d.DataStatus)
                   .IsRequired();


            builder.HasOne(d => d.DataCategory)
                .WithMany()
                .HasForeignKey(d => d.DataCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Author)
                .WithMany()
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
