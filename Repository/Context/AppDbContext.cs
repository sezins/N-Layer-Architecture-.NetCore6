using CoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 150,
                Width = 12,
                ProductId = 1
            },
            new ProductFeature()
            {
                Id = 2,
                Color = "Siyah",
                Height = 125,
                Width = 16,
                ProductId = 2
            });
            //model olusurken calısacak olan metod
            base.OnModelCreating(modelBuilder);
        }


    }
}
