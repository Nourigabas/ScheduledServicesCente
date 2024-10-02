import { Guid } from "guid-typescript";
import { ServiceOwner } from "../service.owner/service.owner";
import { Service } from "../service/service";
import { CategoryService } from "../category.service/category.service";

export interface Sector {
    Id: Guid;
    TypeSector:string;
    IsAccept:boolean;
    Description: string;
    IsDeleted: boolean ;
    ServiceOwners: ServiceOwner[];
    Services: Service[];
    CategoryServices: CategoryService[];
}