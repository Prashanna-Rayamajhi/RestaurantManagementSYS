using System.ComponentModel.DataAnnotations;

public class Menu{
    public int ID { get; set; }
    [Required]
    [MaxLength(40, ErrorMessage ="Menu Name cannot be longer than 40 characters")]
    public string Name { get; set; }
    [Required]
    [MaxLength(250, ErrorMessage = "Description can only be upto 250 characters long.")]
    public string Description { get; set; }

    [Required]
    [Length(5, 40, ErrorMessage ="Type of menu must be longer than 5 character and within 40 character long")]
    public string  Type { get; set; }

    [Required]
    public string Image{get; set;}
    public bool Availability {get; set;}

    public DateTime? Validity {get; set;}
    [Required]
    [RegularExpression("[^0-1000]-[^10-1000]")]
    public string PriceRange {get; set;}
}

