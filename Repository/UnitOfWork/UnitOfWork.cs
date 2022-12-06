using CoreProject.UnitOfWorks;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext  context)
        {
            _context = context;
        }
        //senkron kayıt ıcın
        public void Commit()
        {
            _context.SaveChanges();
        }
        //asenkron kayıt ıcın
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
