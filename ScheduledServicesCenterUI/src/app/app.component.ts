import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterModule, WebsiteInterfaceComponent],
  template: `<router-outlet></router-outlet>`,
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'ScheduledServicesCenterUI';
}
