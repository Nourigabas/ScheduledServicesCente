import { Guid } from "guid-typescript";
import { ServiceOwner } from "../service.owner/service.owner";
import { CategoryService } from "../category.service/category.service";
import { Appointment } from "../appointment/appointment";
import { Reservation } from "../reservation/reservation";
import { Sector } from "../sector/sector";

export interface Service{
    Id:Guid;
    Description:string;
    Location:string;
    IsDeleted:boolean;
    IsAccepted:boolean;
    ServiceOwnerId:Guid;
    ServiceOwner:ServiceOwner;
    CategoryServiceId:Guid;
    CategoryService:CategoryService;
    Appointments:Appointment[];
    Reservations:Reservation[];
    SectorId:Guid;
    Sector:Sector;







}