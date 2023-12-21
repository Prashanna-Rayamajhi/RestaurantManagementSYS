import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { MenusComponent } from "./menus.component";
import { MenuComponent } from "./menu/menu.component";
import { ImageSliderComponent } from "../../Utilities/image-slider/image-slider.component";

@NgModule({
    declarations: [MenuComponent, MenusComponent],
    imports: [CommonModule, ImageSliderComponent],
    exports: [MenusComponent,
                MenuComponent]
})

export class MenuModule{}