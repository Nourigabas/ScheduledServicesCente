import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-website-interface',
  standalone: true,
  imports: [RouterOutlet, RouterModule],
  templateUrl: './website-interface.component.html',
  styleUrl: './website-interface.component.css',
})
export class WebsiteInterfaceComponent {}
