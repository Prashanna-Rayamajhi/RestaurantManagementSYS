using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/dish")]
public class DishController: ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    public DishController(RestaurantContext context, IMapper mapper)
    {
        this._mapper = mapper;
        this._context = context;
    }
    //Http Actions
    [HttpGet]
    public async Task<ActionResult<List<DishDTO>>> GetDishes(){
        var dish = await _context.Dishes.Include(d => d.MenuDishes).ThenInclude(d => d.Menu)
        .ToListAsync();

        var dishDTO = _mapper.Map<List<DishDTO>>(dish);

        return Ok(dishDTO);
    }
   

}