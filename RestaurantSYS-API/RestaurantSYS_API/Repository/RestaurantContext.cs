using Microsoft.EntityFrameworkCore;

public class RestaurantContext : DbContext {
    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
    {
        
    }
    DbSet<Menu> Menus {get; set;}
    DbSet<Dish> Dishes {get; set;}

    DbSet<MenuDish> MenuDishes {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //creating the composite key to act as PK for the entity MenuDish 
        modelBuilder.Entity<MenuDish>().HasKey(key => new{key.DishID, key.MenuID});

        base.OnModelCreating(modelBuilder);
    }
}