using CoreProject.IRepository;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet =context.Set<T>();
        }
        //gerıyebırsey donmeyecegı ıcın async yazarız
        public async Task AddAsync(T entity)
        {
            await  _dbSet.AddAsync(entity);
            _context.SaveChanges(); 
        }

        public async Task AddRangeAsync(IEnumerable<T> entites)
        {
            await _dbSet.AddRangeAsync(entites);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }
        //Efcore aldıgı dataları  memorye cekmesın. performans arttırmak ıcın gereklı.Dastayı alma ıslemı oldugu ıcın asnotrackıng dedıgımız ıcın 
        //daha verımlı olmasını saglarız.
        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }
        
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public  void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public  void RemoveRange(IEnumerable<T> entites)
        {
            _dbSet.RemoveRange(entites);
        }

        public  void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
