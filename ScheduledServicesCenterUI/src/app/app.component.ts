import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';
import { SectorComponent } from './sector/sector.component';
import { LoginComponent } from './login/login.component';
import { CategoryServiceComponent } from './category.service/category.service.component';
import { ServiceComponent } from './service/service.component';
import { ReservationComponent } from './reservation/reservation.component';
import { AppointmentComponent } from "./appointment/appointment.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, WebsiteInterfaceComponent, SectorComponent, LoginComponent, CategoryServiceComponent, ServiceComponent, ReservationComponent, AppointmentComponent],
  template: `
<app-service></app-service  >
  `,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ScheduledServicesCenterUI';
}
