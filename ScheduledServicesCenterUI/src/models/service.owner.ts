import { Guid } from "guid-typescript"
import { Service } from "./service";
import { Sector } from "./sector";
import { Evaluation } from "./evaluation";
import { User } from "./user";

export class ServiceOwner {
    Id: Guid | undefined;
    FullName: string | undefined;
    DateOfBirth: Date | undefined;
    Phone: string | undefined;
    Gmail: string | undefined;
    Site: string | undefined;
    UrlImgPersonalIdentity: string | undefined;
    UrlImgWorkIdentity: string | undefined;
    UrlCV: string | undefined;
    IsAccepted: boolean | undefined;
    IsDeleted: boolean | undefined;
    UserName: string | undefined;
    Password: string | undefined;
    EvaluationAverage: number | undefined;
    Services: Service[] | undefined;
    Evaluatios: Evaluation[] | undefined;
    SectorId: Guid | undefined;
    Sector: Sector | undefined;
    UserId : Guid | undefined;
    User: User | undefined;

}