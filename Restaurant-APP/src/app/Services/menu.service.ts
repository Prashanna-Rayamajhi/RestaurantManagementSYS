import { Injectable } from "@angular/core";
import { Menu } from "../Models/menu.model";
import { Subject } from "rxjs";

@Injectable(
    {providedIn: "root"}
)
export class MenuService{
    public menuSelected: Subject<Menu> = new Subject<Menu>();
    private menus: Menu[] = [
        {
            id: 1, 
            name: "Breakfast",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
            type: "Breakfast",
            availability: true,
            validityPeriod: null,
            imageUrl: "https://images.pexels.com/photos/2136862/pexels-photo-2136862.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            priceRange: "$5.55-19.99",
            icon: "../../../assets/Images/breakfast.svg",
            dishes: [{
              id: 1,
              name: 'Eggs Benedict',
              description: 'A classic breakfast dish consisting of two halves of an English muffin, each topped with Canadian bacon, a poached egg, and hollandaise sauce.',
              imageUrl: "https://images.pexels.com/photos/2122294/pexels-photo-2122294.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
              price: 5.99,
              availability: true,
              category: 2,
              ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
            },
            {
              id: 2,
              name: 'Pancakes',
              description: 'Fluffy pancakes served with maple syrup, butter, and fresh berries.',
              imageUrl: 'https://images.pexels.com/photos/376464/pexels-photo-376464.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
              price: 5.99,
              availability: true,
              category: 2,
              ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
            },
            {
              id: 3,
              name: 'Avocado Toast',
              description: 'Toasted bread topped with mashed avocado, olive oil, salt, pepper, and optional toppings like tomatoes, feta cheese, or poached eggs.',
              imageUrl: 'https://images.pexels.com/photos/1351238/pexels-photo-1351238.jpeg?auto=compress&cs=tinysrgb&w=600',
              price: 5.99,
              availability: true,
              category: 1,
              ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
            }]
          },
          {
            id: 2, 
            name: "Lunch",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
            type: "Lunch",
            availability: true,
            validityPeriod: null,
            imageUrl: "https://images.pexels.com/photos/1683549/pexels-photo-1683549.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            priceRange: "$9.55-29.99",
            icon: "../../../assets/Images/lunch.svg",
            dishes: [
              {
                id: 4,
                name: 'Grilled Chicken Salad',
                description: 'A healthy salad with grilled chicken, mixed greens, cherry tomatoes, cucumber, and a vinaigrette dressing.',
                imageUrl: 'https://images.pexels.com/photos/792027/pexels-photo-792027.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 10.99,
                availability: true,
                category: 2,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 5,
                name: 'Margherita Pizza',
                description: 'Classic Italian pizza topped with tomato sauce, fresh mozzarella cheese, basil leaves, and a drizzle of olive oil.',
                imageUrl: 'https://images.pexels.com/photos/18912713/pexels-photo-18912713/free-photo-of-pizza-with-mozzarella-shaped-as-ghosts-for-halloween.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 12.50,
                availability: true,
                category: 2,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 6,
                name: 'Teriyaki Beef Stir Fry',
                description: 'Stir-fried beef with vegetables in a flavorful teriyaki sauce, served with steamed rice or noodles.',
                imageUrl: 'https://images.pexels.com/photos/7474372/pexels-photo-7474372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 14.75,
                availability: true,
                category: 5,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              }
            ]
          },
          {
            id: 3, 
            name: "Drinks",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
            type: "Drinks",
            availability: true,
            validityPeriod: null,
            imageUrl: "https://images.pexels.com/photos/1889571/pexels-photo-1889571.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            priceRange: "$2.55-9.99", 
            icon: "../../../assets/Images/drinks.svg",
            dishes: [
              {
                id: 7,
                name: 'Iced Coffee',
                description: 'Chilled coffee served over ice cubes, often with milk or cream and sweetened to taste.',
                imageUrl: 'https://images.pexels.com/photos/19055624/pexels-photo-19055624/free-photo-of-iced-coffee-with-whipped-cream.jpeg?auto=compress&cs=tinysrgb&w=600',
                price: 4.99,
                availability: true,
                category: 4,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 8,
                name: 'Fresh Fruit Smoothie',
                description: 'Blended drink made with a mix of fresh fruits, yogurt, and sometimes honey or fruit juice.',
                imageUrl: 'https://images.pexels.com/photos/3625372/pexels-photo-3625372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 6.25,
                availability: true,
                category: 4,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 9,
                name: 'Mint Lemonade',
                description: 'Refreshing drink made with freshly squeezed lemon juice, mint leaves, sugar, and cold water.',
                imageUrl: 'https://images.pexels.com/photos/2109099/pexels-photo-2109099.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 3.75,
                availability: true,
                category: 4,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              } 
            ]
          },
          {
            id: 4, 
            name: "Special",
            description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?",
            type: "Chef's Specialty",
            availability: true,
            validityPeriod: null,
            imageUrl: "https://images.pexels.com/photos/958545/pexels-photo-958545.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
            priceRange: "$9.55-29.99",
             icon: "../../../assets/Images/special.svg",
            dishes: [
              {
                id: 10,
                name: 'Seafood Paella',
                description: 'Spanish rice dish cooked with a variety of seafood, saffron, vegetables, and flavorful spices.',
                imageUrl: 'https://images.pexels.com/photos/12419160/pexels-photo-12419160.jpeg?auto=compress&cs=tinysrgb&w=600',
                price: 18.99,
                availability: true,
                category: 5,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 11,
                name: 'Filet Mignon',
                description: 'Tender beef steak, typically grilled or pan-seared, known for its tenderness and rich flavor.',
                imageUrl: 'https://images.pexels.com/photos/8588647/pexels-photo-8588647.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 22.50,
                availability: true,
                category: 5,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              },
              {
                id: 12,
                name: 'Vegetarian Moussaka',
                description: 'A Greek casserole dish made with layers of eggplant, potatoes, tomato sauce, and creamy béchamel.',
                imageUrl: 'https://images.pexels.com/photos/7226367/pexels-photo-7226367.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
                price: 16.75,
                availability: true,
                category: 1,
                ingredients: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?"
              }
            ]
          }
    ];
    public getMenus(){
        return this.menus.slice();
    }
    public menuSelectionChanged(id: number){
        const menu = <Menu>this.menus.find(menu => menu.id == id);
        this.menuSelected.next(menu);
    }

}