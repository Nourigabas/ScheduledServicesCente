import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { WebsiteInterfaceComponent } from './website-interface/website-interface.component';

export const routes: Routes = [
  { path: 'login', component: LoginComponent },

  { path: '', component: WebsiteInterfaceComponent },
  { path: '**', component: WebsiteInterfaceComponent },
];
