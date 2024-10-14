import { Guid } from "guid-typescript"
import { Reservation } from "./reservation";
import { Evaluation } from "./evaluation";
import { ServiceOwner } from "./service.owner";

export class User {
    constructor(value?: User){
        Object.assign(this, value)
    }
    Id: Guid | undefined;
    FullName: string | undefined;
    DateOfBirth: Date | undefined;
    Phone: string | undefined;
    Gmail: string | undefined;
    UserName: string | undefined;
    Password: string | undefined;
    IsDeleted: boolean | undefined;
    IsOwner: boolean | undefined;
    EvaluationId: Guid | undefined;
    Evaluation: Evaluation | undefined;
    OwnerServiceId: Guid | undefined;
    ServiceOwner: ServiceOwner | undefined;
    Reservations: Reservation[] | undefined;
}