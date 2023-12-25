import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HomeModule } from './Body/home.module';

import { NavbarComponent } from './Header/navbar/navbar.component';
import { MenuModule } from './Body/menus/menu.module';
import { DishesModule } from './Body/dishes/dishes.module';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
              CommonModule,
              RouterOutlet, 
              HomeModule,
              MenuModule,
              NavbarComponent,
              DishesModule
            ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Restaurant APP';
}
