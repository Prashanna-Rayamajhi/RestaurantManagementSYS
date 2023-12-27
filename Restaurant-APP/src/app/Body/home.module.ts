import { NgModule } from "@angular/core";
import { HomeComponent } from "./home/home.component";
import { CommonModule } from "@angular/common";
import { MenuComponent } from "./menu/menu.component";
import { DishComponent } from "./dish/dish.component";
import { HomeService } from "../Services/home.service";
import { MenuService } from "../Services/menu.service";


@NgModule({
    declarations: [HomeComponent, 
                     MenuComponent,
                     DishComponent],
    imports: [CommonModule],
    exports: [HomeComponent, 
               MenuComponent,
               DishComponent],
    providers: [HomeService, MenuService]
})
export class HomeModule {};