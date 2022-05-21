using Microsoft.EntityFrameworkCore;


namespace ASP.NET.WEBAPP.Entities
{
    public class MyAppDbContext : DbContext 
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
