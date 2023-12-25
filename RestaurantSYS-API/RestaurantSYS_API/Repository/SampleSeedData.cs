
public class SampleSeedData{
    public static void SeedData(RestaurantContext _context){
        if(!_context.Menus.Any()){
            string[] menusName = {"Breakfast Menu", "Lunch Menu", "Dinner Menu", "Dessert Menu", "Drinks Menu", "Special Menu"};
            string[] menusDescription = {"Delicious Breakfast items made with eggs, sauces etc.", "Variety of launch specials with authentic taste of different cusines", "Exquisite Dinner Choices.", "Indulge in our sweet treats", "Varitety of hot and cold drinks to with distinguishing falvors.", "A special treat with special you."};
            string[] priceRange = {"$5.59-$12.99", "$6.99-$14.99", "$6.99-19.99", "$4.99-$10.99", "$2.99-$9.99", "$12.99-$19.99"};
            string[] images ={
                "https://images.pexels.com/photos/4551414/pexels-photo-4551414.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/660282/pexels-photo-660282.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/6211048/pexels-photo-6211048.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/6210958/pexels-photo-6210958.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/633501/pexels-photo-633501.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/4946547/pexels-photo-4946547.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            };
            List<Menu> menus = new List<Menu>();
            for(int i = 0; i < menusName.Length; i++){
                menus.Add(new Menu{
                    Name = menusName[i],
                    Description = menusDescription[i],
                    Type = menusName[i],
                    Availability = true,
                    PriceRange = priceRange[i],
                    Validity = null,
                    Image = images[i]
                });
            }
            _context.AddRange(menus);
            _context.SaveChanges();
        }
        if(!_context.Categories.Any()){
            string[] categoriesNames = {"Starter", "Main Dish", "Drinks" ,"Desserts", "Special"};
            List<Category> categories = new List<Category>();
            foreach(var cat in categoriesNames){
                categories.Add(new Category {Name = cat});
            }
            _context.Categories.AddRange(categories);
            _context.SaveChanges();
        }
        if(!_context.Dishes.Any()){
            string[] dishesName = {"Spaghetti Bolognese", "Cesar Salad", "Grilled Salmon", "Margherita Pizza", "Chicken Alferdo", "Vegetable Stir-Fry", "Tiramisu", "Beef Burger", "Penne Arrabbiata", "Sushi Platter"};
            string[] description = {"Classic Italian pasta dish", "Fresh salad with Caesar dressing", "Grilled salmon fillet with lemon butter", "Traditional Italian pizza", "Creamy pasta with grilled chicken", "Stir-fried vegetables with soy sauce", "Classic Italian dessert", "Juicy beef patty with lettuce and cheese", "Spicy tomato based pasta dish","Assorted sushi selection"};
            string[] ingredients = {"Pasta, Ground Beef, Tomato Sauce, Parmesan", "Romaine Lettuce, Croutons, Parmesan, Dressing", "Salmon, Lemon, Butter, Herbs", "Dough, Tomato Sauce, Mozzarella, Basil", "Fettucine, Grilled Chicken, Alfredo Sauce, Parmesan", "Broccoli, Bell Peppers, Carrots, Soy Sauce", "LadyFingers, Espresso, Mascarpone, Cocoa Powder", "Beef Patty, Lettuce, Tomato, Cheddar Cheese", "Penne Pasta, Spicy Tomato Sauce, Garlic, Red Pepper Flakes", "Rice, Salmon, Tuna, Nori, Soy Sauce, Wasabi"};
            decimal[] prices = {10.99M, 8.49M, 16.99M, 12.50M, 14.99M, 9.99M, 7.50M, 11.49M, 12.99M, 18.75M};
            string[] images = {
                "https://images.pexels.com/photos/2092906/pexels-photo-2092906.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/19409039/pexels-photo-19409039/free-photo-of-spinach-and-avocado-on-plate.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/725991/pexels-photo-725991.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/7474114/pexels-photo-7474114.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/6210747/pexels-photo-6210747.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/5836771/pexels-photo-5836771.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/12916029/pexels-photo-12916029.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/19345996/pexels-photo-19345996/free-photo-of-beef-burger-with-melted-cheese.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/5419344/pexels-photo-5419344.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                "https://images.pexels.com/photos/10488749/pexels-photo-10488749.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            };
            Random random = new Random();
            List<Dish> dishes = new List<Dish>();
            for(int i = 0; i < dishesName.Length; i++){
                
                dishes.Add(new Dish{
                    Name = dishesName[i],
                    Description = description[i],
                    CategoryID = random.Next(1, _context.Categories.Count()),
                    Ingredients = ingredients[i],
                    Price = prices[i],
                    ImageURL = images[i],
                });
            }
            _context.AddRange(dishes);
            _context.SaveChanges();
        }
        if(!_context.MenuDishes.Any()){
            var menuIDs = _context.Menus.Select(menu => menu.ID).ToList();
            var dishIDs = _context.Dishes.Select(dish => dish.ID).ToList();

           Random random = new Random();
           int numberOfEntries = 10; // Change this as needed

            HashSet<(int MenuID, int DishID)> uniqueMenuDishes = new HashSet<(int MenuID, int DishID)>();

            while (uniqueMenuDishes.Count < numberOfEntries)
            {
                int randomMenuID = menuIDs[random.Next(0, menuIDs.Count)];
                int randomDishID = dishIDs[random.Next(0, dishIDs.Count)];

                if (!uniqueMenuDishes.Contains((randomMenuID, randomDishID)))
                {
                    uniqueMenuDishes.Add((randomMenuID, randomDishID));
                }
            }

            List<MenuDish> menuDishes = uniqueMenuDishes.Select(_ => new MenuDish{
                MenuID = _.MenuID,
                DishID = _.DishID
            }).ToList();

            _context.AddRange(menuDishes);
            _context.SaveChanges();
        }
    }
}