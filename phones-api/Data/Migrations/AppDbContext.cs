using phones_api.Phones.Models;
using Microsoft.EntityFrameworkCore;

namespace phones_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Phone> Phones {get; set; }
    }
}
