import { Guid } from "guid-typescript";
import { ServiceOwner } from "./service.owner";
import { CategoryService } from "./category.service";
import { Appointment } from "./appointment";
import { Reservation } from "./reservation";
import { Sector } from "./sector";

export class Service {
    Id: Guid | undefined;
    Description: string | undefined;
    Location: string | undefined;
    IsDeleted: boolean | undefined;
    IsAccepted: boolean | undefined;
    ServiceOwnerId: Guid | undefined;
    ServiceOwner: ServiceOwner | undefined;
    CategoryServiceId: Guid | undefined;
    CategoryService: CategoryService | undefined;
    Appointments: Appointment[] | undefined;
    Reservations: Reservation[] | undefined;
    SectorId: Guid | undefined;
    Sector: Sector | undefined;
}