using CoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product 
            { Id = 1, CategoryId = 1,Name="Pencil", Price = 100,Stock=20,CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now },
            new Product
            {Id=2,CategoryId=1, Name = "Pencil2", Price =200,Stock=30,CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now},
            new Product
            { Id = 3, CategoryId =2, Name = "Books", Price = 200, Stock = 30, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
        }
    }
}
