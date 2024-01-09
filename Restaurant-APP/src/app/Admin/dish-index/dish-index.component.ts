import { Component, OnInit } from '@angular/core';
import { Dish } from '../../Models/dish.model';
import { DishesService } from '../../Services/dishes.service';

@Component({
  selector: 'app-dish-index',
  templateUrl: './dish-index.component.html',
  styleUrl: './dish-index.component.css'
})
export class DishIndexComponent implements OnInit{
 dishes !: Dish[];
 showModal : boolean = false;
 constructor(private dishService: DishesService){}
 ngOnInit(): void {
   this.dishService.getAllDishes().subscribe({
    next:  dishes => this.dishes = dishes,
   })
 }
 addBtnClicked(){
  console.log("clicked")
  this.showModal = !this.showModal;
 }
 modalHide(){
  this.showModal = false;
 }
}
