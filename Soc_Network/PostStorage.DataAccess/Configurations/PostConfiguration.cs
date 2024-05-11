
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostStorage.DataAccess.Entites;

namespace PostStorage.DataAccess.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.Message).IsRequired();
        }
    }
}
