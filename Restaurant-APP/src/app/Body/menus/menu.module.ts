import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MenusComponent } from "./menus.component";
import { ImageSliderComponent } from "../../Utilities/image-slider/image-slider.component";
import { HomeModule } from "../home.module";

@NgModule({
    declarations: [MenusComponent],
    imports: [CommonModule, ImageSliderComponent, HomeModule],
    exports: [MenusComponent]
})

export class MenuModule{}