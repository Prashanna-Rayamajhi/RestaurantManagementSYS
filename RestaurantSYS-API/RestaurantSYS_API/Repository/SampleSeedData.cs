
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
            _context.AddRange(
                new Dish{
                    Name = "Eggs Benedict",
                    Description = "A classic breakfast dish consisting of two halves of an English muffin, each topped with Canadian bacon, a poached egg, and hollandaise sauce.",
                    ImageURL = "https://images.pexels.com/photos/2122294/pexels-photo-2122294.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 1
                },
                new Dish{
                    Name = "Pancakes",
                    Description = "Fluffy pancakes served with maple syrup, butter, and fresh berries.",
                    ImageURL = "https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 1
                },
                new Dish{
                    Name = "Avocado Toast",
                    Description = "Toasted bread topped with mashed avocado, olive oil, salt, pepper, and optional toppings like tomatoes, feta cheese, or poached eggs.",
                    ImageURL = "https://images.pexels.com/photos/1351238/pexels-photo-1351238.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 1
                },
                new Dish{
                    Name = "Grilled Chicken Salad",
                    Description = "A healthy salad with grilled chicken, mixed greens, cherry tomatoes, cucumber, and a vinaigrette dressing.",
                    ImageURL = "https://images.pexels.com/photos/792027/pexels-photo-792027.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 1
                },
                new Dish{
                    Name = "Teriyaki Beef Stir Fry",
                    Description = "Stir-fried beef with vegetables in a flavorful teriyaki sauce, served with steamed rice or noodles.",
                    ImageURL = "https://images.pexels.com/photos/7474372/pexels-photo-7474372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 14.99M,
                    CategoryID = 5
                },
                new Dish{
                    Name = "Iced Coffee",
                    Description = "Chilled coffee served over ice cubes, often with milk or cream and sweetened to taste.",
                    ImageURL = "https://images.pexels.com/photos/19055624/pexels-photo-19055624/free-photo-of-iced-coffee-with-whipped-cream.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 3
                },
                new Dish{
                    Name = "Fresh Fruit Smoothie",
                    Description = "Blended drink made with a mix of fresh fruits, yogurt, and sometimes honey or fruit juice.",
                    ImageURL = "https://images.pexels.com/photos/3625372/pexels-photo-3625372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 3
                },
                new Dish{
                    Name = "Mint Lemonade",
                    Description = "Refreshing drink made with freshly squeezed lemon juice, mint leaves, sugar, and cold water.",
                    ImageURL = "https://images.pexels.com/photos/2109099/pexels-photo-2109099.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 5.99M,
                    CategoryID = 3
                },
                new Dish{
                    Name = "Seafood Paella",
                    Description = "Spanish rice dish cooked with a variety of seafood, saffron, vegetables, and flavorful spices.",
                    ImageURL = "https://images.pexels.com/photos/12419160/pexels-photo-12419160.jpeg?auto=compress&cs=tinysrgb&w=600",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 15.99M,
                    CategoryID = 2
                },
                new Dish{
                    Name = "Filet Mignon",
                    Description = "Tender beef steak, typically grilled or pan-seared, known for its tenderness and rich flavor.",
                    ImageURL = "https://images.pexels.com/photos/8588647/pexels-photo-8588647.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 15.99M,
                    CategoryID = 2
                },new Dish{
                    Name = "Vegetarian Moussaka",
                    Description = "A Greek casserole dish made with layers of eggplant, potatoes, tomato sauce, and creamy béchamel.",
                    ImageURL = "https://images.pexels.com/photos/7226367/pexels-photo-7226367.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 18.99M,
                    CategoryID = 5
                },new Dish{
                    Name = "Garlic Shrimp Skewers",
                    Description = "Grilled shrimp skewers marinated in a garlic-infused olive oil, served with a side of zesty lemon wedges.",
                    ImageURL = "https://images.pexels.com/photos/6270541/pexels-photo-6270541.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Ingredients = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
                    Price = 15.99M,
                    CategoryID = 5
                }
            );
            _context.SaveChanges();
        }
        if(!_context.MenuDishes.Any()){
            var menuIDs = _context.Menus.Select(menu => menu.ID).ToArray();
            var dishIDs = _context.Dishes.Select(dish => dish.ID).ToArray();

           Random random = new Random();
           int numberOfEntries = 60; // Change this as needed

            HashSet<(int MenuID, int DishID)> uniqueMenuDishes = new HashSet<(int MenuID, int DishID)>();

            while (uniqueMenuDishes.Count < numberOfEntries)
            {
                int randomMenuID = menuIDs[random.Next(0, menuIDs.Length)];
                int randomDishID = dishIDs[random.Next(0, dishIDs.Length)];

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