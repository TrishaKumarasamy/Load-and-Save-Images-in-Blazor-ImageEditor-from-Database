using Microsoft.EntityFrameworkCore;

namespace BlazorAppDB.Data
{
    public class ImageDbContext: DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options)
    : base(options)
        {
        }

        public DbSet<CustomImageData> ImageCollections { get; set; }

    }
}
