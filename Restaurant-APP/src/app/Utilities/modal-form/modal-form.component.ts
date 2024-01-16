import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormType } from '../../ViewModel/form.enum';

@Component({
  selector: 'app-modal-form',
  templateUrl: './modal-form.component.html',
  styleUrl: './modal-form.component.css'
})
export class ModalFormComponent {
  @Output() canceled: EventEmitter<void> = new EventEmitter<void>();
  @Input() formType !: string;
}
