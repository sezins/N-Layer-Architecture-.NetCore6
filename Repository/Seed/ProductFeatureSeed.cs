using CoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seed
{
    public class ProductFeatureSeed:IEntityTypeConfiguration<ProductFeatureSeed>
    {
        public void Configure(EntityTypeBuilder<ProductFeatureSeed> builder)
        {
            builder.HasData(new ProductFeature{Id=1,Color="Red",Height=100,Width=200,ProductId=1},
                new ProductFeature { Id =2, Color = "Pink", Height = 100, Width = 200, ProductId = 2 },
                new ProductFeature { Id = 3, Color = "Purple", Height = 100, Width = 200, ProductId = 3 }
                );
        }
    }
}
