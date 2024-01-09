import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { AuthorizeComponent } from '../../Security/authorize/authorize.component';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, AuthorizeComponent],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent implements OnInit {
  ngOnInit(): void {
    
  }
  isChecked: boolean = false;
  chkBoxChecked(){
    this.isChecked = !this.isChecked;
  }
}
