import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  url= "https://localhost:7265/api/user"

  constructor(private http: HttpClient) { }
  getAllUsers(): Observable<User[]>{
    return this.http.
  }
}
