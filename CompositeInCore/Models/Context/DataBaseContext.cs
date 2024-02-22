namespace CompositeInCore.Models.Context;

using CompositeInCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

public class DataBaseContext:DbContext
{
    public DataBaseContext(DbContextOptions options):base(options)
    {
        
    }
    public DbSet<CategoryComponent> categoryComponents { get; set; }
    private DbSet<Category> Categories { get; set; }
    private DbSet<CategoryItem> categoryItems { get; set; }
    public DbSet<Product> products { get; set; }
}
