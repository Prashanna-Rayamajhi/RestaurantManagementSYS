import { Component, Input, OnInit } from '@angular/core';
import { Menu } from '../../Models/menu.model';
import { MenuService } from '../../Services/menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit{
  @Input() menuModel !: Menu;
  constructor(private menuService: MenuService){}
  ngOnInit(): void {
    this.menuService.menuSelected.subscribe(menu => this.menuModel = menu);
    if(!this.menuModel){
      this.menuModel = {id: 99, name: "Delicious Meal", description: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure aliquam laboriosam libero laudantium rerum quia, at, fugit dicta est id commodi, quibusdam incidunt aperiam ratione accusamus similique quos itaque quas?", priceRange: "$12.99-$45.55", imageUrl: "https://images.pexels.com/photos/70497/pexels-photo-70497.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", icon: "", availability: true, validityPeriod: null, type: "special", dishes: [
        {
          id: 6,
          name: 'Teriyaki Beef Stir Fry',
          description: 'Stir-fried beef with vegetables in a flavorful teriyaki sauce, served with steamed rice or noodles.',
          imageUrl: 'https://images.pexels.com/photos/7474372/pexels-photo-7474372.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
          price: 14.75
        },
        {
          id: 7,
          name: 'Iced Coffee',
          description: 'Chilled coffee served over ice cubes, often with milk or cream and sweetened to taste.',
          imageUrl: 'https://images.pexels.com/photos/2615323/pexels-photo-2615323.jpeg?auto=compress&cs=tinysrgb&w=600',
          price: 4.99
        },
        {
          id: 12,
          name: 'Vegetarian Moussaka',
          description: 'A Greek casserole dish made with layers of eggplant, potatoes, tomato sauce, and creamy béchamel.',
          imageUrl: 'https://images.pexels.com/photos/7226367/pexels-photo-7226367.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1',
          price: 16.75
        }
      ]}
    }
  }

}
