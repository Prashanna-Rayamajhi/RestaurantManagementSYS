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

    [HttpGet("{id}")]
    public async  Task<ActionResult<CategoryDTO>> GetCategorybyID(int id){
        var category =await _context.Categories.FindAsync(id);
        if(category == null){
            return NotFound("No data found");
        }
        var categoryDTO = _mapper.Map<CategoryDTO>(category);

        return Ok(categoryDTO);
    }
    [HttpPost]
    public async Task<ActionResult> CreateCategory([FromBody] CategoryCreationDTO categoryDTO){
        if(categoryDTO == null){
            return BadRequest("Data provided was not valid.");
        }
        try{
            var category = _mapper.Map<Category>(categoryDTO);
             _context.Add(category);
             await _context.SaveChangesAsync();
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> EditCategory(int id, [FromBody] CategoryCreationDTO categoryDTO){
        if(categoryDTO == null){
            return BadRequest("The provided data was not valid.");
        }
        if(await _context.Categories.AnyAsync(c => c.ID == id)){
            return NotFound("The data to be changed was not found");
        }
        try{
            var updatedCategory = _mapper.Map<Category>(categoryDTO);
            updatedCategory.ID = id;
            _context.Entry(updatedCategory).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCategory(int id){
        var categoryToDelete = await _context.Categories.FindAsync(id);
        if(categoryToDelete == null){
            return NotFound("Data to delete was not found");
        }
        try{
             _context.Categories.Remove(categoryToDelete);
            await _context.SaveChangesAsync();
        }
        catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
}