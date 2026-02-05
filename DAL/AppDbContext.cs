using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        modelbuilder.Entity<Payment>()
        .HasDiscriminator<string>("PayementType")
        .HasValue<CardPayment>("Card")
        .HasValue<UPIPayment>("UPIPayement")
        .HasValue<WalletPayment>("WalletPayment");
    }

}