import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MenusComponent } from "./menus.component";
import { ImageSliderComponent } from "../../Utilities/image-slider/image-slider.component";
import { HomeModule } from "../home.module";
import { MenuService } from "../../Services/menu.service";

@NgModule({
    declarations: [MenusComponent],
    imports: [CommonModule, ImageSliderComponent, HomeModule],
    exports: [MenusComponent],
    providers: [MenuService]
})

export class MenuModule{}