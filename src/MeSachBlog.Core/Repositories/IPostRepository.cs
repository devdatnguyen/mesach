using MeSachBlog.Core.Domain.Content;
using MeSachBlog.Core.Models;
using MeSachBlog.Core.Models.Content;
using MeSachBlog.Core.SeedWorks;

namespace MeSachBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
