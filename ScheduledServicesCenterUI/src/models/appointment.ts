
import { Guid } from 'guid-typescript'; 
import { Service } from './service';
import { Reservation } from './reservation';


export class Appointment {

    Id: Guid | undefined;
    TheAppointment: Date | undefined;
    IsDeleted: boolean | undefined;
    IsBooked: boolean | undefined;
    ServiceId: Guid | undefined;
    Service: Service | undefined;
    ReservationId: Guid | null | undefined;
    Reservation: Reservation| null | undefined;
}

