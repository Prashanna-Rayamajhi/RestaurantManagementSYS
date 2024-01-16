import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoryService } from '../../../Services/category.service';
import { Category } from '../../../Models/category.model';
import { MenuService } from '../../../Services/menu.service';
import { Menu } from '../../../Models/menu.model';
import { CheckboxVM } from '../../../ViewModel/checkbox.vm';

@Component({
  selector: 'app-dish-form',
  templateUrl: './dish-form.component.html',
  styleUrl: './dish-form.component.css'
})
export class DishFormComponent implements OnInit {
  dishForm !: FormGroup;
  categories !: Category[];
  menus!: CheckboxVM[];
  selectedMenus : number[] = [];
  @Output() formCanceled :EventEmitter<void> = new EventEmitter<void>();

  constructor(private formBuilder : FormBuilder, private categoryService: CategoryService, private menuService: MenuService){}

  ngOnInit(): void {
    this.buildTheForm();
    this.categoryService.getCategories().subscribe(category => this.categories = category);
    this.menuService.getMenus().subscribe(menus => this.menus = menus.map(({id, name})=> ({id: id, name: name, checked: false})));
  }

  private buildTheForm(){
    this.dishForm = this.formBuilder.group({
      name : ['', Validators.required],
      description: ['',  {validators: [Validators.required]}],
      image:['', {validators: [Validators.required]}],
      price:[Number, {validators: [Validators.required]}],
      availability: [true, {validators:[Validators.required]}],
      category: ['', {validators:[Validators.required]}],
      ingredients:['', {validators:[Validators.required]}],
      menus:['']
    })
  }
  OnImageSelected(file:File){
    this.dishForm.get("image")?.patchValue(file);
  }
  OnMenuSelected(_id: number){
    if(this.selectedMenus.length > 0){
      let indexOf = this.selectedMenus.indexOf(_id);
      if(indexOf == -1){
        this.selectedMenus.push(_id);
      }else{
        this.selectedMenus.splice(indexOf, 1);
      }
      return;
    }
    this.selectedMenus.push(_id)
  }
  formSubmitted(){
    this.dishForm.get("menus")?.patchValue(this.selectedMenus);
    console.log(this.dishForm.value);
  }
  formCancelled(){
    this.dishForm.reset();
    this.formCanceled.emit();
  }
}
