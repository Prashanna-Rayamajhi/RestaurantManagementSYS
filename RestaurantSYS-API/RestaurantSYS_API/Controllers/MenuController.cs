using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/menu")]
public class MenuController : ControllerBase{
    private readonly RestaurantContext _context;
    private readonly IMapper _mapper;
    private readonly IFileManagement _fileManagement;

    private readonly string imageDirName = "menu-images";

    public MenuController(RestaurantContext context, IMapper mapper, IFileManagement fileManagement)
    {
        this._context = context;
        this._mapper = mapper;
        this._fileManagement = fileManagement;
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
    [HttpGet("{id}")]
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
    public async Task<ActionResult> AddMenu([FromBody] MenuCreationDTO menuCreation){
        if(menuCreation == null){
            return BadRequest("Provided Menu data are not valid");
        }
        try{
           var addedMenu = _mapper.Map<Menu>(menuCreation);
           if(menuCreation.Image != null && menuCreation.Image.Length > 0){
            addedMenu.Image = await _fileManagement.SaveFile(menuCreation.Image, this.imageDirName);
           }
           _context.Add(addedMenu);
           await _context.SaveChangesAsync();
        }catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> EditMenu(int id, [FromForm] MenuCreationDTO creationDTO){
        var menuToEdit = await _context.Menus.Include(m => m.MenuDishes)
        .ThenInclude(d => d.Dish)
        .FirstOrDefaultAsync(m => m.ID == id);
        if(menuToEdit == null){
            return NotFound("Sorry, No menu available to edit as per your request.");
        }
        try{
            menuToEdit = _mapper.Map<Menu>(creationDTO);
            if(creationDTO.Image != null && creationDTO.Image.Length > 0){
                menuToEdit.Image = await _fileManagement.EditFile(creationDTO.Image, imageDirName, menuToEdit.Image);
            }
            _context.Entry(menuToEdit).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
        
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMenu(int id){
        var menu = await _context.Menus.FindAsync(id);
        if(menu == null){
            return BadRequest("No menu was to found to delete. Something bad occured.");
        }
        try{
             _context.Remove(menu);
             await _fileManagement.DeleteFile(menu.Image, imageDirName);
             await _context.SaveChangesAsync();

        }catch(Exception ex){
            return BadRequest(ex.Message);
        }
        return NoContent();
    }
    
}