using CoreProject.Entities;
using CoreProject.IRepository;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdProductAsync(int categoryId)
        {
            return await _context.Categories.Include(x=>x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
            
               
            
        
    }
}
