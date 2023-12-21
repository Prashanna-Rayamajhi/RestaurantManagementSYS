import { Component, Input, OnInit } from '@angular/core';
import { SliderVM } from '../../ViewModel/image-slider.vm';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-image-slider',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './image-slider.component.html',
  styleUrl: './image-slider.component.css'
})
export class ImageSliderComponent implements OnInit {
  @Input() sliderModel !: SliderVM[];

  currentImageLoaded !: SliderVM; 

  currentIndex = 0;

  ngOnInit(): void {
    this.currentImageLoaded = this.sliderModel[0];
    this.startSlider();
  }

  private startSlider(){
    setInterval(()=>{
      this.currentIndex = this.sliderModel.indexOf(this.currentImageLoaded);
      const nextIndex = this.currentIndex < this.sliderModel.length -1 ? this.currentIndex + 1 : 0;
      this.currentImageLoaded = this.sliderModel[nextIndex]; 
    }, 5000)
  }
}
