import { Component, EventEmitter, Input, Output } from '@angular/core';
import { toBase64 } from '../File Management/ImageToBase64';

@Component({
  selector: 'app-input-image',
  templateUrl: './input-image.component.html',
  styleUrl: './input-image.component.css'
})
export class InputImageComponent {
  imageToBase64!: string;

  @Output() OnImageSelected: EventEmitter<File> = new EventEmitter<File>();

  @Input() currentImageURL: string | undefined | null
  onChange(event: any){
    if(event.target.files.length > 0){
      const file: File = event.target.files[0];
      toBase64(file).then((value: string)  =>{this.imageToBase64 = value});
      this.OnImageSelected.emit(file);
      this.currentImageURL = null;
    }
  }
}
