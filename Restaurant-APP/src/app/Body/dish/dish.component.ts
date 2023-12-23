import { Component, Input, OnInit } from "@angular/core";
import { Dish } from "../../Models/dish.model";

@Component({
    selector: 'app-dish',
    templateUrl: './dish.component.html',
    styleUrl: './dish.component.css',
})
export class DishComponent implements OnInit{
    @Input() dishModel !: Dish;

    ngOnInit(): void {
        
    }
}