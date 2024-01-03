using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
[ApiController]
[Route("api/dish")]
public class DishController: ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    private readonly IFileManagement _fileManagement;
    private readonly string imageDirName = "dish-images";

    public DishController(RestaurantContext context, IMapper mapper, IFileManagement fileManagement)
    {
        this._mapper = mapper;
        this._fileManagement = fileManagement;
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
    [HttpGet("category/{catId}")]
    public async Task<ActionResult<List<DishDTO>>> GetDishesByCategory(int catId){
        var dishes = await _context.Dishes.Where(d => d.CategoryID == catId).ToListAsync();

        var dishesDTO = _mapper.Map<List<DishDTO>>(dishes);

        return Ok(dishesDTO);
    }
    //HTTP method to add new dishes to the db
    [HttpPost]
    public async Task<ActionResult> AddDish([FromForm] DishCreationDTO dishDTO){
        if(dishDTO == null){
            return BadRequest("The request cannot be processed due to invalid data structure");
        }
        try{
           var dish = _mapper.Map<Dish>(dishDTO);
           if(dishDTO.Image != null && dishDTO.Image.Length > 0){
                dish.ImageURL = await _fileManagement.SaveFile(dishDTO.Image, imageDirName);
           }
           _context.Add(dish);
           await _context.SaveChangesAsync();
        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> EditDish(int id, [FromForm] DishCreationDTO dishDTO){
        var dishToEdit = await _context.Dishes.Include(d => d.MenuDishes).ThenInclude(d => d.Menu).FirstOrDefaultAsync(d => d.ID == id);
        if(dishToEdit == null){
            return BadRequest("Sorry, Dish to edit was not found. Please try again later");
        }
        try{
            dishToEdit = _mapper.Map<Dish>(dishDTO);
            if(dishDTO.Image != null && dishDTO.Image.Length > 0){
                dishToEdit.ImageURL = await _fileManagement.EditFile(dishDTO.Image, imageDirName, dishToEdit.ImageURL);
            }
            _context.Entry(dishDTO).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            return BadRequest("Sorry, couldn't update your data. " + ex.Message);
        }
        return NoContent();
    }
    [HttpDelete("{int}")]
    public async Task<ActionResult> DeleteDish(int id){
        var dishToDelete = await _context.Dishes.FindAsync(id);
        if(dishToDelete == null){
            return BadRequest("No dishes found to delete");
        }
        try{
            _context.Remove(dishToDelete);
            await _fileManagement.DeleteFile(dishToDelete.ImageURL, imageDirName);
        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }

}