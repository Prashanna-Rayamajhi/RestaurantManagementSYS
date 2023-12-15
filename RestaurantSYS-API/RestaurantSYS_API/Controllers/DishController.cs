using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/dish")]
public class DishController: ControllerBase{
    private readonly RestaurantContext _context;
    public DishController(RestaurantContext context)
    {
        this._context = context;
    }
    //Http Actions
    [HttpGet]
    public async Task<ActionResult<List<Dish>>> GetDishes(){
        return await _context.Dishes.ToListAsync();
    }

}