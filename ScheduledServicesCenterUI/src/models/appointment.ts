
import { Guid } from 'guid-typescript'; 
import { IService } from './service';
import { IReservation } from './reservation';


export interface IAppointment {

    Id: Guid;
    TheAppointment: Date;
    IsDeleted: boolean
    IsBooked: boolean;
    ServiceId: Guid;
    Service: IService;
    ReservationId: Guid | null;
    Reservation: IReservation| null;
}

