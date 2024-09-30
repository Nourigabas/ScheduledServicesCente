
import { Guid } from 'guid-typescript'; 
import { Reservation } from '../reservation/reservation';
import { Service } from '../service/service';

export interface Appointment {

    Id: Guid;
    TheAppointment: any;
    IsDeleted: boolean
    IsBooked: boolean;
    ServiceId: Guid;
    Service: Service;
    ReservationId: Guid | null;
    Reservation: Reservation| null;
}

