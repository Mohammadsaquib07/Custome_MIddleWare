using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class AppDbContextFactory 
    : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=apna_store_db;User Id=sa;Password=Saquib@123;TrustServerCertificate=True;");

        return new AppDbContext(optionsBuilder.Options);
    }
}
