import { Guid } from "guid-typescript"
import { IService } from "./service";
import { ISector } from "./sector";

export interface IServiceOwner {
    Id: Guid;
    FullName: string;
    DateOfBirth: Date;
    Phone: string;
    Gmail: string;
    Site: string;
    IsAccepted: boolean;
    IsDeleted: boolean;
    UserName: string;
    Password: string;
    Services: IService[];
    SectorId: Guid;
    Sector: ISector;
}