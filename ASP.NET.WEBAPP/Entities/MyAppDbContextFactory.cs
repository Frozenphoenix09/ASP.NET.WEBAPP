using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ASP.NET.WEBAPP.Entities
{
    public class MyAppDbContextFactory : IDesignTimeDbContextFactory<MyAppDbContext>
    {
        public MyAppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyAppDbContext>();
            optionBuilder.UseSqlServer("Server=DESKTOP-QLHOVH5\\DATHUNG;Initial Catalog=ASPNETAPP;User Id=dathung091;Password=12344321;");
            return new MyAppDbContext(optionBuilder.Options);
        }
    }
}
