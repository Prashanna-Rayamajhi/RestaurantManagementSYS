import { Component, Input, OnInit } from '@angular/core';
import { SliderVM } from '../../ViewModel/image-slider.vm';
import { CommonModule } from '@angular/common';
import { MenuService } from '../../Services/menu.service';

@Component({
  selector: 'app-image-slider',
  standalone: true,
  imports: [CommonModule],
  providers: [MenuService],
  templateUrl: './image-slider.component.html',
  styleUrl: './image-slider.component.css'
})
export class ImageSliderComponent implements OnInit {
  sliderModel !: SliderVM[];

  currentImageLoaded !: SliderVM; 

  currentIndex = 0;

  constructor(private menuService: MenuService){}

  ngOnInit(): void {
    this.menuService.getMenus().subscribe(menus => {
      this.sliderModel = menus.map(({id, name, description, image}) => ({id, name, description, image}));
      this.currentImageLoaded = this.sliderModel[0];
      this.startSlider();
    })
    
  }

  private startSlider(){
    setInterval(()=>{
      this.currentIndex = this.sliderModel.indexOf(this.currentImageLoaded);
      const nextIndex = this.currentIndex < this.sliderModel.length -1 ? this.currentIndex + 1 : 0;
      this.currentImageLoaded = this.sliderModel[nextIndex]; 
    }, 5000)
  }

  navClick(){
    console.log("clicked");
  }
}
