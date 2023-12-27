using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/category")]
public class CategoryController : ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    public CategoryController(RestaurantContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;

    }

    //HTTP Actions
    [HttpGet]
    public async Task<ActionResult<List<CategoryDTO>>> GetAll(){
        var categories = await _context.Categories.ToListAsync();
        var categoriesDTO = _mapper.Map<List<CategoryDTO>>(categories);
        return Ok(categoriesDTO);
    }

    [HttpGet("{id:int}")]
    public async  Task<ActionResult<CategoryDTO>> GetCategorybyID(int id){
        var category =await _context.Categories.FindAsync(id);
        if(category == null){
            return NotFound("No data found");
        }
        var categoryDTO = _mapper.Map<CategoryDTO>(category);

        return Ok(categoryDTO);
    }
}