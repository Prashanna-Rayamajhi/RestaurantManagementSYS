using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/dish")]
public class DishController: ControllerBase{
    private readonly RestaurantContext _context;
    public DishController(RestaurantContext context)
    {
        this._context = context;
    }

}