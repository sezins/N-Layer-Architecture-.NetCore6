using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        //Asenkron data dön.
        Task<T> GetByIdAsync(int id);
        //productRepository.getall(x=>x.id>5).tolist();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        //Sorgular dırek verıtabanına gıtmez.Performans arttırmak ıcın queryable kullanılırz.productrepository.where(x=>x.id>5).ToListAsync(); productrepository.where(x=>x.id>5) buraya kadar dbye gıtmez bundan sonrası gıder
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
        Task AddAsync(T entity);
        //AddRangeAsync =bırden fazla kayıt yapabılırız.
        //Interface ve abstract larla (soyut ogelerle calısmak onemlı) sebeı ıse newlemeye gerek kalmaz.
        Task AddRangeAsync(IEnumerable<T> entites);
        void Update(T entity);
        //Update ve Remobe efcore tarafıonda async yok 
        void Remove(T entity);  
        void RemoveRange(IEnumerable<T> entites);
    }
}
