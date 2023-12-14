using System.ComponentModel.DataAnnotations;

public class Menu{
    public int ID { get; set; }
    [Required(ErrorMessage ="Name of Menu is required.")]
    [StringLength(40, ErrorMessage ="Menu Name cannot be longer than 40 characters")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Description is required field.")]
    [StringLength(250, ErrorMessage = "Description can only be upto 250 characters long.")]
    public string Description { get; set; }

    [Required(ErrorMessage ="Type of Menu is required.")]
    [StringLength(40, ErrorMessage ="Type of menu must be longer than 5 character and within 40 character long")]
    public string  Type { get; set; }

    [Required]
    public string Image{get; set;}
    public bool Availability {get; set;}

    public DateTime? Validity {get; set;}
    [Required]
    public string PriceRange {get; set;}

    public List<MenuDish> MenuDishes {get; set;}
}

