public class MenuDish{
    public int ID { get; set; }

    public int MenuID { get; set; }
    public Menu Menu { get; set; }

    public int DishID{get; set;}
    public Dish Dish { get; set; }
}