using Azure;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataEntity> Datas { get; set; }
        public DbSet<DataCategoryEntity> DataCategories { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<TagEntity> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}