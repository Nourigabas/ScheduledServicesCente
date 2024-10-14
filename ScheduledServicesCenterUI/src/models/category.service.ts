import { Guid } from 'guid-typescript';
import { Sector } from './sector';
import { Service } from './service';


export class CategoryService {
  Id: Guid | undefined;
  Name: string | undefined;
  UrlCategoryserviceIcon: string | undefined;
  IsDelete: boolean | undefined;
  IsAccepted: boolean | undefined;
  SectorId: Guid | undefined;
  Sector: Sector | undefined;
  Services: Service[] | undefined;
  /**
   *
   */
}
