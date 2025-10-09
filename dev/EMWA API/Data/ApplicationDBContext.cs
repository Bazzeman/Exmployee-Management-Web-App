using EMWA_API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMWA_API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options) { }

    }
}
