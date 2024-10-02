import { Component } from '@angular/core';
import { SectorComponent } from '../sector/sector.component';
import { AppointmentComponent } from '../appointment/appointment.component';

@Component({
  selector: 'app-categoryservice',
  standalone: true,
  imports: [AppointmentComponent],
  templateUrl: './create.category.service.html',
  styleUrl: './category.service.component.css'
})
export class CategoryServiceComponent {

}
