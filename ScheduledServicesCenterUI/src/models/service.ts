import { Guid } from "guid-typescript";
import { IServiceOwner } from "./service.owner";
import { ICategoryService } from "./category.service";
import { IAppointment } from "./appointment";
import { IReservation } from "./reservation";
import { ISector } from "./sector";

export interface IService {
    Id: Guid;
    Description: string;
    Location: string;
    IsDeleted: boolean;
    IsAccepted: boolean;
    ServiceOwnerId: Guid;
    ServiceOwner: IServiceOwner;
    CategoryServiceId: Guid;
    CategoryService: ICategoryService;
    Appointments: IAppointment[];
    Reservations: IReservation[] | null;
    SectorId: Guid;
    Sector: ISector;
}