using Microsoft.EntityFrameworkCore;
using SocNetCurs.Data;

namespace SocNetCurs.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SocNetCursContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SocNetCursContext>>()))
            {
                // Look for any movies.
                if (context.Posts.Any())
                {
                    return;   // DB has been seeded
                }
                context.Posts.AddRange(
                    new Posts
                    {
                        User = "Leo",
                        Message = "Привет!"
                    },
                    new Posts
                    {
                        User = "Leo",
                        Message = "Как дела?!"
                    },
                    new Posts
                    {
                        User = "Leo",
                        Message = "Тут кто-то есть?"
                    },
                    new Posts
                    {
                        User = "Leo",
                        Message = "Хееееей!"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
