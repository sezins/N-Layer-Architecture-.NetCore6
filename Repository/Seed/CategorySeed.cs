﻿using CoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            
            builder.HasData(new Category { Id=1, Name="Pencils"}, 
                           new Category { Id = 2, Name = "Books" },
                           new Category { Id = 3, Name = "NoteBook" });

        }
    }
}
