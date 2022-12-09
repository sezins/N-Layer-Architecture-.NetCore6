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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            //Eager Loadıng: Produck'ı cektıgım anda categoryde cekersem eager loadıng olur.
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
