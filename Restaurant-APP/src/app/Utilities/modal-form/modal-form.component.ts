import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-modal-form',
  templateUrl: './modal-form.component.html',
  styleUrl: './modal-form.component.css'
})
export class ModalFormComponent {
  @Output() canceled: EventEmitter<void> = new EventEmitter<void>();
}
