using AutoMapper;

public class AutoMapperProfile : Profile{
    public AutoMapperProfile()
    {
        CreateMap<Dish, DishDTO>()
            .ForMember(dish => dish.Menus, options => options.MapFrom(MapDishesMenuDTO))
            .ReverseMap();
        CreateMap<DishCreationDTO, Dish>()
        .ForMember(d => d.ImageURL, options => options.Ignore())
        .ForMember(d => d.MenuDishes, options => options.MapFrom(MapMenuDishOfDishCreation));
        CreateMap<Menu, MenuDTO>()
            .ForMember(menu => menu.Dishes, options => options.MapFrom(MapMenuDishesDTO))
            .ReverseMap();   
        CreateMap<MenuCreationDTO, Menu>()
            .ForMember(menu => menu.Image, options => options.Ignore())
            .ForMember(menu => menu.MenuDishes, options => options.MapFrom(MapMenuDishOfMenuCreation));    

        CreateMap<MenuDish, MenuDishDTO>();

        //Working with the Category Data's for creating and editing
        CreateMap<Category, CategoryDTO>()
        .ReverseMap();
        CreateMap<CategoryCreationDTO, Category>();

    }
    private List<MenuDTO> MapDishesMenuDTO(Dish dish, DishDTO dishDTO){
        var result  = new List<MenuDTO>();
        if(dish.MenuDishes != null){
            foreach(var menu in dish.MenuDishes){
                result.Add(new MenuDTO {
                    ID = menu.MenuID,
                    Name = menu.Menu.Name,
                    Description = menu.Menu.Description,
                    Type = menu.Menu.Type,
                    PriceRange = menu.Menu.PriceRange
                });
            }
        }
        return result;
    }
    private List<DishDTO> MapMenuDishesDTO(Menu menu, MenuDTO menuDTO){
        List<DishDTO> dishesDTO = new List<DishDTO>();
        if(menu.MenuDishes != null){
            foreach(var dish in menu.MenuDishes){
                dishesDTO.Add(new DishDTO{
                    ID = dish.Dish.ID,
                    Name = dish.Dish.Name,
                    Description = dish.Dish.Description,
                    Price = dish.Dish.Price,
                    ImageURL = dish.Dish.ImageURL,
                    Ingredients = dish.Dish.Ingredients
                });
            }
        }
        return dishesDTO;
    }
    //mapping of the List of Dishes from creation of Menu to Menu Dishes
    private List<MenuDish> MapMenuDishOfMenuCreation(MenuCreationDTO creationDTO, Menu menu){
        List<MenuDish> menuDishes = new List<MenuDish>();
        if(creationDTO.Dishes == null){
            return menuDishes;
        }
        foreach(var dish in creationDTO.Dishes){
            menuDishes.Add(new MenuDish{DishID = dish});
        }
        return menuDishes;
    }
    private List<MenuDish> MapMenuDishOfDishCreation(DishCreationDTO creationDTO, Dish dish){
         List<MenuDish> menuDishes = new List<MenuDish>();
        if(creationDTO.Menus == null){
            return menuDishes;
        }
        foreach(var menu in creationDTO.Menus){
            menuDishes.Add(new MenuDish{DishID = menu});
        }
        return menuDishes;
    }
}