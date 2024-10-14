import { Guid } from "guid-typescript"
import { IService } from "./service";
import { ISector } from "./sector";
import { IEvaluation } from "./evaluation";
import { IUser } from "./user";

export interface IServiceOwner {
    Id: Guid;
    FullName: string;
    DateOfBirth: Date;
    Phone: string;
    Gmail: string;
    Site: string;
    UrlImgPersonalIdentity: string;
    UrlImgWorkIdentity: string;
    UrlCV: string;
    IsAccepted: boolean;
    IsDeleted: boolean;
    UserName: string;
    Password: string;
    EvaluationAverage: number;
    Services: IService[];
    Evaluatios: IEvaluation[];
    SectorId: Guid;
    Sector: ISector;
    UserId : Guid;
    User: IUser;

}