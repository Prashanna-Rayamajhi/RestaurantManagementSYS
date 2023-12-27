using AutoMapper;

public class AutoMapperProfile : Profile{
    public AutoMapperProfile()
    {
        CreateMap<Dish, DishDTO>()
            .ForMember(dish => dish.Menus, options => options.MapFrom(MapDishesMenuDTO));
        CreateMap<Menu, MenuDTO>()
            .ForMember(menu => menu.Dishes, options => options.MapFrom(MapMenuDishesDTO));   

        CreateMap<MenuDish, MenuDishDTO>()
        .ReverseMap();

        CreateMap<Category, CategoryDTO>()
        .ReverseMap();
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
}