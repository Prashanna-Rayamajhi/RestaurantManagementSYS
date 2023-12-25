import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { DishesComponent } from "./dishes.component";
import { DishesService } from "../../Services/dishes.service";
import { CategoryService } from "../../Services/category.service";




@NgModule({
    declarations: [DishesComponent],
    imports: [CommonModule],
    providers: [DishesService, CategoryService],
    exports: [DishesComponent]
})
export class DishesModule {}