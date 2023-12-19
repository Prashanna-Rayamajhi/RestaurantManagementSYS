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
    [HttpGet("{id}")]
    public async Task<ActionResult<DishDTO>> GetDishByID(int id){
        try{
            var dish = await _context.Dishes.Include(d => d.MenuDishes).ThenInclude(d => d.Menu)
            .FirstOrDefaultAsync(d => d.ID ==id);

            var dishDTO = _mapper.Map<DishDTO>(dish);

            return Ok(dishDTO);
        }catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
        
    }   
    //HTTP method to add new dishes to the db
    [HttpPost]
    public async Task<ActionResult> AddDish([FromBody] Dish dish){
        try{
            _context.Add(dish);
            await _context.SaveChangesAsync();
            return NoContent();
        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
    }

}