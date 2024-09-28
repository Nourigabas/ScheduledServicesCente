import { Component } from '@angular/core';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-website-interface',
  standalone: true,
  imports: [LoginComponent],
  templateUrl: './website-interface.component.html',
  styleUrl: './website-interface.component.css'
})
export class WebsiteInterfaceComponent {

}
