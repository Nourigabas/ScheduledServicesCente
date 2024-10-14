import { Guid } from 'guid-typescript';
import { IServiceOwner } from './service.owner';
import { IService } from './service';
import { ICategoryService } from './category.service';

export interface ISector {
  Id: Guid;
  TypeSector: string;
  Description: string;
  UrlSectorIcon: string;
  IsAccepted: boolean;
  IsDeleted: boolean;
  ServiceOwners: IServiceOwner[];
  Services: IService[];
  CategoryServices: ICategoryService[];
}
