import { Routes } from '@angular/router';
import { MenusComponent } from './Body/menus/menus.component';
import { HomeComponent } from './Body/home/home.component';
import { DishesComponent } from './Body/dishes/dishes.component';
import { MenuIndexComponent } from './Admin/menu-index/menu-index.component';
import { DashboardComponent } from './Admin/dashboard/dashboard.component';
import { DishIndexComponent } from './Admin/dish-index/dish-index.component';
import { OrderIndexComponent } from './Admin/order-index/order-index.component';


export const routes: Routes = [
    {path: "",  component: HomeComponent},
    {path:"menu", component: MenusComponent},
    {path: "dishes", component: DishesComponent},

    //route paths for the admin only
    {path: "dashboard", component: DashboardComponent},
    {path: 'index-menu', component: MenuIndexComponent},
    {path: 'index-dish', component: DishIndexComponent},
    {path: 'index-order', component: OrderIndexComponent}
];
