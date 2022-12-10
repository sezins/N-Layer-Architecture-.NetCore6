using CoreProject.Dto;
using CoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.IService
{
    public interface ICategoryService:IService<Category>
    {
       Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int CategoryId); 
    }
}
