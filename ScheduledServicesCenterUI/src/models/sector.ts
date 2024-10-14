import { Guid } from 'guid-typescript';
import { ServiceOwner } from './service.owner';
import { Service } from './service';
import { CategoryService } from './category.service';

export class Sector {
  Id: Guid | undefined;
  TypeSector: string | undefined;
  Description: string | undefined;
  UrlSectorIcon: string | undefined;
  IsAccepted: boolean | undefined;
  IsDeleted: boolean | undefined;
  ServiceOwners: ServiceOwner[] | undefined;
  Services: Service[] | undefined;
  CategoryServices: CategoryService[] | undefined;
}
