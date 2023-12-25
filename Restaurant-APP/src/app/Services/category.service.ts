import { Injectable } from "@angular/core";
import { Category } from "../Models/category.model";

//category service is required currently in dishes page hence will be injected at dishes module file.
@Injectable(
    {
        providedIn: "platform"
    }
)
export class CategoryService{
    private categories: Category[] = [
        {
            id: 0,
            name: "All"
        },
        {
            id: 1,
            name: "Starter",
        },    
        {
            id: 2,
            name: "Main Dish",
        },
        {
            id: 3,
            name: "Desserts",
        },
        {
            id: 4,
            name: "Drinks",
        },
        {
            id: 5,
            name: "Special",
        }
    ];

    public getCategories(){
        return this.categories.slice();
    }
}