using System.ComponentModel.DataAnnotations;

public class Category{
    public int ID { get; set; }
    [Required(ErrorMessage = "Category Name is the required field.")]
    [StringLength(40, ErrorMessage = "Name cannot be longer than 40 characters")]
    public string Name { get; set; }

    public List<Dish> Dishes {get; set;}
}