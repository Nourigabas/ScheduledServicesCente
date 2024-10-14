import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
url= "https://localhost:7265/api/CategoryService/"
  constructor(private http: HttpClient) { }
  PostCategory(category: CategoryService){
    return this.http.post(this.url + "create", category);
  }
}
