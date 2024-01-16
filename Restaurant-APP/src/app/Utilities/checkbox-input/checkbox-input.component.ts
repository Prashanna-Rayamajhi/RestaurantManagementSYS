import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CheckboxVM } from '../../ViewModel/checkbox.vm';

@Component({
  selector: 'app-checkbox-input',
  templateUrl: './checkbox-input.component.html',
  styleUrl: './checkbox-input.component.css'
})
export class CheckboxInputComponent {
  @Input() checkboxModel !: CheckboxVM[];
  @Output() selectionChanged : EventEmitter<number> = new EventEmitter<number>();
}
