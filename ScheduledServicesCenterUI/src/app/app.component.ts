import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,WebsiteInterfaceComponent],
  template: `<app-website-interface></app-website-interface>`,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ScheduledServicesCenterUI';
}
