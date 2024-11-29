using MeSachBlog.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeSachBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeSachContext _context;
        public UnitOfWork(MeSachContext context)
        {
            _context = context;
        }
        public async Task<int> CampleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
