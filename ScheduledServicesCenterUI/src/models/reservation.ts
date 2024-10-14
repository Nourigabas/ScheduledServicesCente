import { Guid } from "guid-typescript";
import { User } from "./user";
import { Service } from "./service";
import { Appointment } from "./appointment";

export class Reservation {
    Id: Guid | undefined;
    IsDelete: boolean | undefined;
    UserId: Guid | undefined;
    User: User | undefined;
    ServiceId: Guid | undefined;
    Service: Service | undefined;
    AppointmentId: Guid | undefined;
    Appointment: Appointment | undefined;
}