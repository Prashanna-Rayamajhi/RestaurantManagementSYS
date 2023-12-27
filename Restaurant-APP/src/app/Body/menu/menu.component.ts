import { Component, Input, OnInit } from '@angular/core';
import { Menu } from '../../Models/menu.model';
import { MenuService } from '../../Services/menu.service';
import { Dish } from '../../Models/dish.model';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit{
  @Input() menuModel !: Menu;
  constructor(private menuService: MenuService){}
  ngOnInit(): void {
    this.menuService.menuSelected.subscribe(menu => this.menuModel = menu);
    }

}
