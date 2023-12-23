import { NgModule } from "@angular/core";
import { HomeComponent } from "./home/home.component";
import { CommonModule } from "@angular/common";
import { MenuComponent } from "./menu/menu.component";
import { DishComponent } from "./dish/dish.component";


@NgModule({
    declarations: [HomeComponent, 
                     MenuComponent,
                     DishComponent],
    imports: [CommonModule],
    exports: [HomeComponent, 
               MenuComponent,
               DishComponent]
})
export class HomeModule {};