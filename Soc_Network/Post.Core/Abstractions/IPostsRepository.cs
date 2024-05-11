using PostStorage.Core.Models;

namespace PostStorage.DataAccess.Repositories
{
    public interface IPostsRepository
    {
        Task<Guid> Create(Post post);
        Task<Guid> Delete(Guid id);
        Task<List<Post>> Get();
        Task<Guid> Update(Guid id, string user, string message);
    }
}