using Microsoft.EntityFrameworkCore;
using Aakriti_MVC.Models;
namespace Aakriti_MVC.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
