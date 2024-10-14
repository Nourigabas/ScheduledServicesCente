import { Guid } from 'guid-typescript'; 
import { Service } from './service';
import { User } from './user';


export class Evaluation {

    Id: Guid | undefined;
    EvaluationValue: Number | undefined;
    IsDeleted: boolean | undefined;
    ServiceId: Guid | undefined;
    Service: Service | undefined;
    Users: User[] | undefined;
}

