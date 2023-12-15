using AutoMapper;

public class AutoMapperProfile : Profile{
    public AutoMapperProfile()
    {
        CreateMap<Dish, DishDTO>()
            .ReverseMap();
        CreateMap<Menu, MenuDTO>()
            .ReverseMap();    
    }
}