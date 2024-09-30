import { Guid } from "guid-typescript"
import { Reservation } from "../reservation/reservation";

export interface User {
    Id: Guid;
    FullName: string;
    DateOfBirth: Date;
    Phone: string;
    Gmail: string;
    UserName: string;
    Password: string;
    IsDeleted: boolean;
    Reservations: Reservation[];
}