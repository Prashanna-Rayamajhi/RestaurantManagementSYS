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
  public sliderView !: SliderVM[];
  constructor(private menuService: MenuService) {}

  ngOnInit(): void {
    this.menus = this.menuService.getMenus();
    this.sliderView = this.menus.map(({id, name, description, imageUrl}) => ({id, name, description, imageUrl}));
  }
  navBtnClicked(id: number){
    this.menuService.menuSelectionChanged(id);
  }

}
