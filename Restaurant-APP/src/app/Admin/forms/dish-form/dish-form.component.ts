import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-dish-form',
  templateUrl: './dish-form.component.html',
  styleUrl: './dish-form.component.css'
})
export class DishFormComponent implements OnInit {
  dishForm !: FormGroup;
  @Output() formCanceled :EventEmitter<void> = new EventEmitter<void>();
  constructor(private formBuilder : FormBuilder){}
  ngOnInit(): void {
    this.buildTheForm();
  }

  private buildTheForm(){
    this.dishForm = this.formBuilder.group({
      name : [' ', Validators.required],
      description: [' ',  {validators: [Validators.required]}],
      imageURL:[' ', {validators: [Validators.required]}],
      price:[' ', {validators: [Validators.required]}],
      availability: [true, {validators:[Validators.required]}],
      category: [' ', {validators:[Validators.required]}],
      ingredients:[' ', {validators:[Validators.required]}]
    })
  }
}
