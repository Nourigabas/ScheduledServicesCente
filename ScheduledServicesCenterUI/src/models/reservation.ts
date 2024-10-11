import { Guid } from "guid-typescript";
import { IUser } from "./user";
import { IService } from "./service";
import { IAppointment } from "./appointment";

export interface IReservation {
    Id: Guid;
    IsDelete: boolean;
    UserId: Guid;
    User: IUser;
    ServiceId: Guid;
    Service: IService;
    AppointmentId: Guid;
    Appointment: IAppointment;
}