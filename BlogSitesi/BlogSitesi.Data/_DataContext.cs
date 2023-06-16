using BlogSitesi.Model.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSitesi.Data.Infrastructure;

namespace BlogSitesi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base (new DbContextOptionsBuilder().UseMySQL(connectionString).Options) { }

        public DbSet<Model.Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Model.Author>(entity => entity.ToTable("you_Authors"));

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(bool))
                    {
                        property.SetValueConverter(new BoolToIntConverter());
                    }
                }
            }



        }



    }
}
