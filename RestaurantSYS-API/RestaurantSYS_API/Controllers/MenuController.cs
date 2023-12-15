using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/menu")]
public class MenuController : ControllerBase{
    private readonly RestaurantContext _context;
    public MenuController(RestaurantContext context)
    {
        this._context = context;
    }
    
}