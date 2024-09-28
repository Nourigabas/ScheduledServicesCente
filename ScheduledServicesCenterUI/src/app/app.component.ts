import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';
import { SectorComponent } from './sector/sector.component';
import { LoginComponent } from './login/login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,WebsiteInterfaceComponent,SectorComponent,LoginComponent],
  template: `<app-website-interface></app-website-interface>`,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ScheduledServicesCenterUI';
}
