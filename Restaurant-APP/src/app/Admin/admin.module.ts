import { NgModule } from "@angular/core";
import { MenuIndexComponent } from "./menu-index/menu-index.component";
import { MenuService } from "../Services/menu.service";
import { DashboardComponent } from "./dashboard/dashboard.component";
import { DishIndexComponent } from "./dish-index/dish-index.component";
import { OrderIndexComponent } from "./order-index/order-index.component";
import { CommonModule } from "@angular/common";
import { DishesService } from "../Services/dishes.service";
import { DishFormComponent } from "./forms/dish-form/dish-form.component";
import { MenuFormComponent } from "./forms/menu-form/menu-form.component";
import { ReactiveFormsModule } from "@angular/forms";
import { ModalFormComponent } from "../Utilities/modal-form/modal-form.component";
import { InputImageComponent } from "../Utilities/input-image/input-image.component";
import { CheckboxInputComponent } from "../Utilities/checkbox-input/checkbox-input.component";

@NgModule({
    declarations: [MenuIndexComponent,
                    DashboardComponent,
                    DishIndexComponent,
                    OrderIndexComponent,
                    ModalFormComponent,
                    DishFormComponent,
                    MenuFormComponent,
                    InputImageComponent,
                    CheckboxInputComponent],
    providers: [MenuService, DishesService],
    imports:[CommonModule, ReactiveFormsModule],
    exports: [MenuIndexComponent,
                DashboardComponent,
                DishIndexComponent,
                OrderIndexComponent,
                DishFormComponent,
                ModalFormComponent,
                MenuFormComponent,
                InputImageComponent,
                CheckboxInputComponent]
})
export class AdminModule{}