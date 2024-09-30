import { Guid } from "guid-typescript";
import { User } from "../user/user";
import { Service } from "../service/service";
import { Appointment } from "../appointment/appointment";

export interface Reservation {
    Id: Guid;
    IsDelete: boolean;
    UserId: Guid;
    User: User;
    ServiceId: Guid;
    Service: Service;
    AppointmentId: Guid;
    Appointment: Appointment;
}