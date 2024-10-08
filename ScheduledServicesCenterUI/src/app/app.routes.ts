import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';
import { SectorComponent } from './sector/sector.component';
import { CategoryServiceComponent } from './category.service/category.service.component';
import { CategoryServiceDetailsComponent } from './category.service.details/category.service.details.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'sector', component: SectorComponent },
  { path: 'category', component: CategoryServiceComponent },
  { path: 'servdetails', component: CategoryServiceDetailsComponent },

  { path: '', component: WebsiteInterfaceComponent },
  { path: '**', component: WebsiteInterfaceComponent },
];
