using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/menu")]
public class MenuController : ControllerBase{
    private readonly RestaurantContext _context;
    public MenuController(RestaurantContext context)
    {
        this._context = context;
    }
    //working with Http Actions
    [HttpGet]
    public async Task<ActionResult<List<Menu>>> GetMenus(){
        return await _context.Menus.ToListAsync();
    }
}