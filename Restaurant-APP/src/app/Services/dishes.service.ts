import { Injectable } from "@angular/core";
import { Dish } from "../Models/dish.model";
import { HttpClient } from "@angular/common/http";
import { environment } from "../../environment/environment";
import { Observable } from "rxjs";

@Injectable(
  {
    providedIn: "platform"
  }
)
export class DishesService{
    constructor(private http: HttpClient){}
    private apiUrl = environment.apiURL + "dish";
    private dishes: Dish[] = [
        {
            id: 1,
            name: 'Eggs Benedict',
            description: 'A classic breakfast dish consisting of two halves of an English muffin, each topped with Canadian bacon, a poached egg, and hollandaise sauce.',
            imageURL: "https://images.pexels.com/photos/2122294/pexels-photo-2122294.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            price: 5.99,
            availability: true,
            category: 2,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 2,
            name: 'Pancakes',
            description: 'Fluffy pancakes served with maple syrup, butter, and fresh berries.',
            imageURL: 'https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 5.99,
            availability: true,
            category: 2,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 3,
            name: 'Avocado Toast',
            description: 'Toasted bread topped with mashed avocado, olive oil, salt, pepper, and optional toppings like tomatoes, feta cheese, or poached eggs.',
            imageURL: 'https://images.pexels.com/photos/1351238/pexels-photo-1351238.jpeg?auto=compress&cs=tinysrgb&w=600',
            price: 5.99,
            availability: true,
            category: 1,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
        },
        {
            id: 4,
            name: 'Grilled Chicken Salad',
            description: 'A healthy salad with grilled chicken, mixed greens, cherry tomatoes, cucumber, and a vinaigrette dressing.',
            imageURL: 'https://images.pexels.com/photos/792027/pexels-photo-792027.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 10.99,
            availability: true,
            category: 2,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 5,
            name: 'Margherita Pizza',
            description: 'Classic Italian pizza topped with tomato sauce, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil.',
            imageURL: 'https://images.pexels.com/photos/18912713/pexels-photo-18912713/free-photo-of-pizza-with-mozzarella-shaped-as-ghosts-for-halloween.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 12.50,
            availability: true,
            category: 2,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 6,
            name: 'Teriyaki Beef Stir Fry',
            description: 'Stir-fried beef with vegetables in a flavorful teriyaki sauce, served with steamed rice or noodles.',
            imageURL: 'https://images.pexels.com/photos/7474372/pexels-photo-7474372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 14.75,
            availability: true,
            category: 5,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 7,
            name: 'Iced Coffee',
            description: 'Chilled coffee served over ice cubes, often with milk or cream and sweetened to taste.',
            imageURL: 'https://images.pexels.com/photos/19055624/pexels-photo-19055624/free-photo-of-iced-coffee-with-whipped-cream.jpeg?auto=compress&cs=tinysrgb&w=600',
            price: 4.99,
            availability: true,
            category: 4,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 8,
            name: 'Fresh Fruit Smoothie',
            description: 'Blended drink made with a mix of fresh fruits, yogurt, and sometimes honey or fruit juice.',
            imageURL: 'https://images.pexels.com/photos/3625372/pexels-photo-3625372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 6.25,
            availability: true,
            category: 4,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 9,
            name: 'Mint Lemonade',
            description: 'Refreshing drink made with freshly squeezed lemon juice, mint leaves, sugar, and cold water.',
            imageURL: 'https://images.pexels.com/photos/2109099/pexels-photo-2109099.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 3.75,
            availability: true,
            category: 4,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 10,
            name: 'Seafood Paella',
            description: 'Spanish rice dish cooked with a variety of seafood, saffron, vegetables, and flavorful spices.',
            imageURL: 'https://images.pexels.com/photos/12419160/pexels-photo-12419160.jpeg?auto=compress&cs=tinysrgb&w=600',
            price: 18.99,
            availability: true,
            category: 5,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 11,
            name: 'Filet Mignon',
            description: 'Tender beef steak, typically grilled or pan-seared, known for its tenderness and rich flavor.',
            imageURL: 'https://images.pexels.com/photos/8588647/pexels-photo-8588647.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 22.50,
            availability: true,
            category: 5,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 12,
            name: 'Vegetarian Moussaka',
            description: 'A Greek casserole dish made with layers of eggplant, potatoes, tomato sauce, and creamy béchamel.',
            imageURL: 'https://images.pexels.com/photos/7226367/pexels-photo-7226367.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
            price: 16.75,
            availability: true,
            category: 1,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
          },
          {
            id: 13,
            name: "Caprese Salad",
            description: "A classic Italian starter featuring fresh mozzarella cheese, ripe tomatoes, basil leaves, and a drizzle of balsamic glaze.",
            price: 9.99,
            availability: true,
            ingredients: "Fresh mozzarella cheese, tomatoes, basil leaves, balsamic glaze, olive oil, salt, and pepper.",
            imageURL: "https://images.pexels.com/photos/2097090/pexels-photo-2097090.jpeg?auto=compress&cs=tinysrgb&w=600",
            category: 1
        },
        {
            id: 14,
            name: "Garlic Shrimp Skewers",
            description: "Grilled shrimp skewers marinated in a garlic-infused olive oil, served with a side of zesty lemon wedges.",
            price: 9.99,
            availability: true,
            ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
            imageURL: "https://images.pexels.com/photos/6270541/pexels-photo-6270541.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            category: 1
            
        } 
    ]

    //methods to get data from the service class
   
    public getDishByID(_id:number){
        const dish = this.dishes.find(dish => dish.id == _id);
        if(dish){
           return dish; 
        }
        return undefined;
    }
    //working with API's
    public getAllDishes(): Observable<Dish[]>{
      return this.http.get<Dish[]>(this.apiUrl);
    }
    public getDishesByCategory(_categoryID: number): Observable<Dish[]>{
      if(_categoryID != 0){
        return this.http.get<Dish[]>(this.apiUrl + "/category/" + _categoryID);
      }
      return this.getAllDishes();
  }
}