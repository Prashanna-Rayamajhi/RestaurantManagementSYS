using Microsoft.EntityFrameworkCore;

public class RestaurantContext : DbContext {
    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
    {
        
    }
    public DbSet<Menu> Menus {get; set;}
    public DbSet<Dish> Dishes {get; set;}
    public DbSet<MenuDish> MenuDishes {get; set;}

    public DbSet<Category> Categories {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //creating the composite key to act as PK for the entity MenuDish 
        modelBuilder.Entity<MenuDish>().HasKey(key => new{key.DishID, key.MenuID});

        modelBuilder.Entity<Category>()
            .HasMany(ct => ct.Dishes)
            .WithOne(d => d.Category)
            .HasForeignKey(d => d.CategoryID);

        base.OnModelCreating(modelBuilder);
    }
}