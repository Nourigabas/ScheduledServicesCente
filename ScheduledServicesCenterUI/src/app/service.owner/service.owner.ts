import { Guid } from "guid-typescript"
import { Service } from "../service/service";
import { Sector } from "../sector/sector";

export interface ServiceOwner{
    Id:Guid;
    FullName:string;
    DateOfBirth:Date;
    Phone:string;
    Gmail:string;
    Site:string;
    UrlImgPersonalIdentity:string;
    UrlImgWorkIdentity:string;
    UrlCV:string;
    IsAccepted:boolean;
    IsDeleted:boolean;
    UserName:string;
    Password:string;
    Services:Service[];
    SectorId:Guid;
    Sector:Sector;
}