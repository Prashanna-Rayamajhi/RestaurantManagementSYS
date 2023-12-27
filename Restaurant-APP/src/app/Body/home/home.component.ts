import { Component, OnInit } from '@angular/core';
import { HomeService } from '../../Services/home.service';
import { Menu } from '../../Models/menu.model';
import { Dish } from '../../Models/dish.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit{
  menuModel !: Menu;
  constructor(private homeService: HomeService){}
  ngOnInit(): void {
    this.homeService.getHomePageData().subscribe(home => {
      this.menuModel = <Menu>home.menu;
    });
  }
  
}
