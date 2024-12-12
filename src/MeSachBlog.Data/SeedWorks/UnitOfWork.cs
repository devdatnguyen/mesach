using AutoMapper;
using MeSachBlog.Core.Repositories;
using MeSachBlog.Core.SeedWorks;
using MeSachBlog.Data.Repositories;
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
        public UnitOfWork(MeSachContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
            PostCategories = new PostCategoryRepository(context, mapper);
        }
        public IPostRepository Posts { get; private set; }
        public IPostCategoryRepository PostCategories { get; private set; }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
