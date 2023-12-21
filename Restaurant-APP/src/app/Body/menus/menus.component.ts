import { Component, OnInit } from '@angular/core';
import { Menu } from '../../Models/menu.model';
import { SliderVM } from '../../ViewModel/image-slider.vm';

@Component({
  selector: 'app-menus',
  templateUrl: './menus.component.html',
  styleUrl: './menus.component.css'
})
export class MenusComponent implements OnInit{
   menus: Menu[] = [
    {
      id: 1, 
      name: "Breakfast",
      description: "Breakfast",
      type: "Breakfast",
      availability: true,
      validityPeriod: null,
      imageUrl: "https://images.pexels.com/photos/2136862/pexels-photo-2136862.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
      priceRange: "$5.55-19.99"
    },
    {
      id: 2, 
      name: "Lunch",
      description: "Lunch",
      type: "Lunch",
      availability: true,
      validityPeriod: null,
      imageUrl: "https://images.pexels.com/photos/2641886/pexels-photo-2641886.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
      priceRange: "$9.55-29.99"
    },
    {
      id: 3, 
      name: "Drinks",
      description: "Drinks",
      type: "Drinks",
      availability: true,
      validityPeriod: null,
      imageUrl: "https://images.pexels.com/photos/1889571/pexels-photo-1889571.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
      priceRange: "$2.55-9.99"
    },
    {
      id: 4, 
      name: "Special",
      description: "Hot deal",
      type: "Chef's Specialty",
      availability: true,
      validityPeriod: null,
      imageUrl: "https://images.pexels.com/photos/958545/pexels-photo-958545.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
      priceRange: "$9.55-29.99"
    }
  ];
  public sliderView !: SliderVM[];
  constructor() {}

  ngOnInit(): void {
    this.sliderView = this.menus.map(({id, name, description, imageUrl}) => ({id, name, description, imageUrl}));
  }

}
