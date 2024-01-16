import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-menu-form',
  templateUrl: './menu-form.component.html',
  styleUrl: './menu-form.component.css'
})
export class MenuFormComponent implements OnInit{
  constructor(private formBuilder: FormBuilder){}
  ngOnInit(): void {
    this.buildForm();
  }
  menuForm !: FormGroup
  @Output() formCanceled : EventEmitter<void> = new EventEmitter<void>();
  formCancelled(){
    this.menuForm.reset();
    this.formCanceled.emit();
  }
  private buildForm(){
    this.menuForm = this.formBuilder.group({
      name: ["", {validators:[Validators.required]}],
      type: ["", {validators:[Validators.required]}],
      image: ["", {validators:[Validators.required]}],
      description: ["", {validators:[Validators.required]}],
      priceRange: ["", {validators:[Validators.required]}],
      availability: [true, {validators:[Validators.required]}],
      validity: [Date],
      dishes:[]
    })
  }
  OnImageSelected(image: File){

  }
  formSubmitted(){

  }
}
