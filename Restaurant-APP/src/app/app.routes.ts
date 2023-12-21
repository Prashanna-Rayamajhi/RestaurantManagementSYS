import { Routes } from '@angular/router';
import { MenusComponent } from './Body/menus/menus.component';
import { HomeComponent } from './Body/home/home.component';

export const routes: Routes = [
    {path: "",  component: HomeComponent},
    {path:"menu", component: MenusComponent}
];
