import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';
import { SectorComponent } from './sector/sector.component';
import { CategoryServiceComponent } from './category.service/category.service.component';
import { CategoryServiceDetailsComponent } from './category.service.details/category.service.details.component';
import { OwnreServiceDetailsComponent } from './ownre.service.details/ownre.service.details.component';
import { ServiceComponent } from './service/service.component';
import { ServiceOwnerComponent } from './service.owner/service.owner.component';
import { UserComponent } from './user/user.component';
import { ReservationComponent } from './reservation/reservation.component';
import { CreateSeviceComponent } from './create.sevice/create.sevice.component';
import { CreateAccountUserComponent } from './create.user.account/create.account.user.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'sector', component: SectorComponent },
  { path: 'category', component: CategoryServiceComponent },
  { path: 'servdetails', component: CategoryServiceDetailsComponent },
  { path: 'owner', component: OwnreServiceDetailsComponent },
  { path: 'service', component: ServiceComponent },
  { path: 'reservation', component: ReservationComponent },
  { path: 'user', component: UserComponent },
  { path: 'serviceowner', component: ServiceOwnerComponent },
  { path: 'createservice', component: CreateSeviceComponent },
  { path: 'createuser', component: CreateAccountUserComponent },

  { path: '', component: WebsiteInterfaceComponent },
  { path: '**', component: WebsiteInterfaceComponent },
];
