import { Guid } from 'guid-typescript';
import { Sector } from '../sector/sector';
import { Service } from '../service/service';

export interface CategoryService {
  Id: Guid;
  Name: string;
  UrlBackgroundImage:string;
  IsDelete: boolean; 
  SectorId: Guid;
  Sector: Sector;
  Services: Service[];
  /**
   *
   */
}
