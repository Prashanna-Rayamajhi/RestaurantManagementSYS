import { Component, OnInit } from '@angular/core';
import { Menu } from '../../Models/menu.model';
import { SliderVM } from '../../ViewModel/image-slider.vm';
import { MenuService } from '../../Services/menu.service';


@Component({
  selector: 'app-menus',
  templateUrl: './menus.component.html',
  styleUrl: './menus.component.css'
})
export class MenusComponent implements OnInit{
  menus: Menu[] = [];
  sliderView !: SliderVM[];
  selectedIndex = 0;
  constructor(private menuService: MenuService) {}

  ngOnInit(): void {
    this.menuService.getMenus().subscribe({
      next: menus => this.menus = menus,
    })    
  }
  navBtnClicked(id: number){
    this.menuService.menuSelectionChanged(id);
  }

}
