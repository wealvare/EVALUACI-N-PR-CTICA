using Microsoft.EntityFrameworkCore;
using System.Data;
using WebAPP_Wilber_Alvarez_26._11._05.models;

namespace WebAPP_Wilber_Alvarez_26._11._05.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
