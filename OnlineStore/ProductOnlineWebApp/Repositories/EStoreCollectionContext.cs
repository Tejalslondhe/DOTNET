using Microsoft.EntityFrameworkCore;
using BOL;



namespace DAL;

public class EStoreCollectionContext:DbContext
{
    public DbSet<Product> products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"server=localhost;port=3306;user=root; password=root;database=cdac24";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.title).IsRequired();
            entity.Property(e => e.description).IsRequired();
            entity.Property(e => e.unit_price).IsRequired();
            entity.Property(e => e.image_url).IsRequired();
            entity.Property(e => e.quantity).IsRequired();



        });

        modelBuilder.Entity<Product>().ToTable("products");

    }

}
