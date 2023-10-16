using Microsoft.EntityFrameworkCore;

namespace InformationSystem_WebAPI.Models
{
    public class InfoSystemDBContext : DbContext
    {
        public InfoSystemDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
