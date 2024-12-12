using MeSachBlog.Core.Domain.Content;
using MeSachBlog.Core.Models.Content;
using MeSachBlog.Core.Models;
using MeSachBlog.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeSachBlog.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
    }
}
