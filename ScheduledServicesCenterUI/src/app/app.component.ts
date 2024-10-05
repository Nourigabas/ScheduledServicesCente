import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';
import { SectorComponent } from './sector/sector.component';
import { LoginComponent } from './login/login.component';
import { CategoryServiceComponent } from './category.service/category.service.component';
import { ServiceComponent } from './service/service.component';
import { ReservationComponent } from './reservation/reservation.component';
import { AppointmentComponent } from "./appointment/appointment.component";
import { ServiceOwnerComponent } from './service.owner/service.owner.component';
import { UserComponent } from "./user/user.component";
import { CreateCategoryServiceComponent } from './create.category.service/create.category.service.component';
import { CreateAccountUserComponent } from './create.user.account/create.account.user.component';
import { CreateAccountOwnerComponent } from './create.account.owner/create.account.owner.component';
import { CreateSectorComponent } from './create.sector/create.sector.component';
import { CreateSeviceComponent } from './create.sevice/create.sevice.component';
import { OwnreServiceDetailsComponent } from './ownre.service.details/ownre.service.details.component';
import { CategoryServiceDetailsComponent } from './category.service.details/category.service.details.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CategoryServiceDetailsComponent,OwnreServiceDetailsComponent,CreateSeviceComponent, CreateSectorComponent, CreateAccountOwnerComponent, CreateAccountUserComponent, CreateCategoryServiceComponent, ServiceOwnerComponent, WebsiteInterfaceComponent, SectorComponent, CategoryServiceComponent, ServiceComponent, ReservationComponent, AppointmentComponent, UserComponent, LoginComponent],
  template: `
<app-createcategoryservice></app-createcategoryservice>




  `,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ScheduledServicesCenterUI';
}
