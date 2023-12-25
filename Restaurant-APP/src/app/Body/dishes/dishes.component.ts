import { Component, OnInit } from '@angular/core';
import { Dish } from '../../Models/dish.model';
import { DishesService } from '../../Services/dishes.service';
import { CategoryService } from '../../Services/category.service';
import { Category } from '../../Models/category.model';

@Component({
  selector: 'app-dishes',
  templateUrl: './dishes.component.html',
  styleUrl: './dishes.component.css'
})
export class DishesComponent implements OnInit {

   dishes !: Dish[]
  categories !: Category[];

  /**
   *
   */
  constructor(private dishesService: DishesService, private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.categories = this.categoryService.getCategories();
    this.dishes = this.dishesService.getAllDishes();
  }
  categorySelected(_id: number){
    this.dishes = this.dishesService.getDishesByCategory(_id);
  }
}
