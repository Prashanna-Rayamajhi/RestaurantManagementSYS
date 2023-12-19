using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/menu")]
public class MenuController : ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    public MenuController(RestaurantContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }
    //working with Http Actions
    [HttpGet]
    public async Task<ActionResult<List<MenuDTO>>> GetMenus(){
        var menus = await _context.Menus
        .Include(m => m.MenuDishes)
        .ThenInclude(m => m.Dish)
        .ToListAsync();

        var menuDTO = _mapper.Map<List<MenuDTO>>(menus);

        return Ok(menuDTO);
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<MenuDTO>> GetMenuByID(int id){
        try{
            var menu = await _context.Menus
            .Include(m => m.MenuDishes)
            .ThenInclude(m => m.Dish)
            .FirstOrDefaultAsync(m => m.ID == id);

        

            var menuDTO = _mapper.Map<MenuDTO>(menu);

            return Ok(menuDTO);
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
        
    }
    //Http Action to add new menu to the db
    [HttpPost]
    public async Task<ActionResult> AddMenu([FromBody] Menu menu){
        try{
             _context.Add(menu);
            await _context.SaveChangesAsync();
            return NoContent();
        }catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
}