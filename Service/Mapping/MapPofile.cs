using AutoMapper;
using CoreProject.Dto;
using CoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapPofile:Profile
    {
        public MapPofile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product,ProductWithCategoryDto >();
            CreateMap<Category,CategoryWithProductsDto >();
        }
    }
}
