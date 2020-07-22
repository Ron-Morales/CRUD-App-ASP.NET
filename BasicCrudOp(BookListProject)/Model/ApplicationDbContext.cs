using Microsoft.EntityFrameworkCore;

namespace BasicCrudOp_BookListProject_.Model
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}