using System.ComponentModel.DataAnnotations;

public class Dish{
    public int ID { get; set; }
    [Required(ErrorMessage ="Name of Dish is required.")]
    [StringLength(50, ErrorMessage ="Name of the dish can only be 50 characters long.")]
    public string  Name { get; set; }
    [StringLength(150, ErrorMessage ="Description of Dish can only be 150 characters long.")]
    public string Description { get; set; }

    [Required(ErrorMessage ="Image is required field")]
    public string ImageURL { get; set; }

    [Required(ErrorMessage = "Ingredeints is required field")]
    [StringLength(100, ErrorMessage ="Ingredinets can be upto 100 characters long")]
    public string  Ingredients { get; set; }
    [Required(ErrorMessage ="Price is a required field")]
    public decimal Price{get; set;}

    public int CategoryID {get; set;}

    public Category Category { get; set; }

    public List<MenuDish> MenuDishes { get; set; }
    
}