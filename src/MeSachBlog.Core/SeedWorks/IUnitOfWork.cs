using MeSachBlog.Core.Repositories;

namespace MeSachBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        Task<int> CompleteAsync();
    }
}
