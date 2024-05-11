using Microsoft.EntityFrameworkCore;
using PostStorage.Core.Models;
using PostStorage.DataAccess.Entites;

namespace PostStorage.DataAccess.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly PostStorageDbContext _context;

        public PostsRepository(PostStorageDbContext context)
        {
            _context = context;
        }

        public async Task<List<Post>> Get()
        {
            var postEnitities = await _context.Posts
                .AsNoTracking()
                .ToListAsync();

            var posts = postEnitities
                .Select(b => Post.Create(b.Id, b.User, b.Message).post)
                .ToList();

            return posts;

        }

        public async Task<Guid> Create(Post post)
        {
            var postEntity = new PostEntity
            {
                Id = post.Id,
                User = post.User,
                Message = post.Message,
            };
            await _context.Posts.AddAsync(postEntity);
            await _context.SaveChangesAsync();

            return postEntity.Id;
        }
        public async Task<Guid> Update(Guid id, string user, string message)
        {
            await _context.Posts
                .Where(b => b.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.User, b => user)
                .SetProperty(b => b.Message, message));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Posts
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

    }
}
