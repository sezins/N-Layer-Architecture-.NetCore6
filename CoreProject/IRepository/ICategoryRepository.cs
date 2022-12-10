using CoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.IRepository
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdProductAsync(int categoryId);
    }
}
