import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Resturant } from '../Models/resturant';

@Injectable({
  providedIn: 'root'
})
export class ResturantService {
  url : string = "http://localhost:3000/Resturant"
  constructor(private http: HttpClient) { }

  public getAllResturant() : Observable<Resturant[]>{
    return this.http.get<Resturant[]>(this.url)
  }
  public getEmployee(id: number) : Observable<Resturant>{
    let tempurl = this.url + "/" +id;
    return this.http.get<Resturant>(tempurl);
  }
  public addEmployee(res:Resturant): Observable<Resturant>{
    return this.http.post<Resturant>(this.url,res);
  }
  public deleteEmployee(id: number): Observable<Resturant[]>{
    let tempurl = this.url + "/" +id;
    return this.http.delete<Resturant[]>(tempurl);
  }
  public updateEmployee(res : Resturant) : Observable<Resturant>{
    const tempUrl = this.url + "/" + res.id;
    return this.http.put<Resturant>(tempUrl, res);
  }
}


