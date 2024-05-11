using Microsoft.EntityFrameworkCore;
using PostStorage.DataAccess.Entites;

namespace PostStorage.DataAccess
{
    public class PostStorageDbContext:DbContext
    {
        public PostStorageDbContext(DbContextOptions<PostStorageDbContext>options)
            : base(options)
        {

        }
        public DbSet<PostEntity> Posts { get; set; }
    }
}