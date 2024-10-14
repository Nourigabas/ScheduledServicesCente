import { Guid } from "guid-typescript"
import { IReservation } from "./reservation";
import { IEvaluation } from "./evaluation";
import { IServiceOwner } from "./service.owner";

export interface IUser {
    Id: Guid;
    FullName: string;
    DateOfBirth: Date;
    Phone: string;
    Gmail: string;
    UserName: string;
    Password: string;
    IsDeleted: boolean;
    IsOwner: boolean;
    EvaluationId: Guid;
    Evaluation: IEvaluation
    OwnerServiceId: Guid;
    ServiceOwner: IServiceOwner;
    Reservations: IReservation[];
}