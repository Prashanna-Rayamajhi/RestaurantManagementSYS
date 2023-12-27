using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/home")]
public class HomeController : ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    public HomeController(RestaurantContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<HomeDTO>> Get(){
        var menu = await _context.Menus.FirstOrDefaultAsync( m => m.Name.Contains("Special"));

        var dishes = await _context.Dishes
        .Include(d => d.MenuDishes.Where(d => d.MenuID == menu.ID))
        .Take(3)
        .ToListAsync();

        var menuDTO = _mapper.Map<MenuDTO>(menu);
        var dishDTO = _mapper.Map<List<DishDTO>>(dishes);
        menuDTO.Dishes = dishDTO;
        
        return Ok(new HomeDTO {Menu = menuDTO});
    }
}