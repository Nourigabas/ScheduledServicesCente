import { Guid } from 'guid-typescript'; 
import { IService } from './service';
import { IUser } from './user';


export interface IEvaluation {

    Id: Guid;
    EvaluationValue: Number;
    IsDeleted: boolean;
    ServiceId: Guid;
    Service: IService;
    Users: IUser[];
}

