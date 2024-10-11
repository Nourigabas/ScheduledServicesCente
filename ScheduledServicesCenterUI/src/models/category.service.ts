import { Guid } from 'guid-typescript';
import { ISector } from './sector';
import { IService } from './service';


export interface ICategoryService {
  Id: Guid;
  Name: string;
  IsDelete: boolean;
  IsAccepted: boolean;
  SectorId: Guid;
  Sector: ISector;
  Services: IService[];
  /**
   *
   */
}
