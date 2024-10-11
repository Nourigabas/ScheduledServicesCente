import { Guid } from "guid-typescript"
import { IReservation } from "./reservation";

export interface IUser {
    Id: Guid;
    FullName: string;
    DateOfBirth: Date;
    Phone: string;
    Gmail: string;
    UserName: string;
    Password: string;
    IsDeleted: boolean;
    Reservations: IReservation[];
}