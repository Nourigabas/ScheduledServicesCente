import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FileService {
    url= "https://localhost:7265/api/File"
  constructor(private http: HttpClient) { }
  UploadFile(file: File): Observable<string>{
    const formData: FormData=new FormData()
    formData.append('file',file)
    return this.http.post<string>(this.url,formData)
  }
}
