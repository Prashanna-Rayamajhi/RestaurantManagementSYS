using System.ComponentModel.DataAnnotations;

public class CategoryCreationDTO{
    [Required]
    [StringLength(40, ErrorMessage = "Name cannot be longer than 40 characters")]
    public string Name { get; set; }

}