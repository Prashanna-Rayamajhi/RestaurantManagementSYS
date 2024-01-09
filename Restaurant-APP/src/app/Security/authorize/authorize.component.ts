import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-authorize',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './authorize.component.html',
  styleUrl: './authorize.component.css'
})
export class AuthorizeComponent {
  private isAuthenticated: boolean = true;
  role: string = 'admin';

  IsAuthenticated(){
    return this.isAuthenticated;
  }
}
