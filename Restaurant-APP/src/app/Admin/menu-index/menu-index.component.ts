import { Component, OnInit } from '@angular/core';
import { MenuService } from '../../Services/menu.service';
import { Menu } from '../../Models/menu.model';

@Component({
  selector: 'app-menu-index',
  templateUrl: './menu-index.component.html',
  styleUrl: './menu-index.component.css'
})
export class MenuIndexComponent implements OnInit{
  menus !: Menu[];
  showModal : boolean = false;
  constructor(private menuService : MenuService){}
  ngOnInit(): void {
    this.menuService.getMenus().subscribe({
      next: (menu) => this.menus = menu,
    })
  }
  addBtnClicked(){
    this.showModal = !this.showModal;
   }
   modalHide(){
    this.showModal = false;
   }
}
