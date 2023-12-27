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
    this.dishesService.getAllDishes().subscribe({
      next: dishes => this.dishes = dishes
    });
    this.categoryService.getCategories().subscribe(category =>{
      this.categories = [{id: 0, name: "All"}, ...category]
    })
  }
  categorySelected(_id: number){
    this.dishesService.getDishesByCategory(_id).subscribe(dishes => this.dishes = dishes);
  }
}
