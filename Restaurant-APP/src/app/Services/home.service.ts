import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Home } from "../Models/home.model";
import { environment } from "../../environment/environment";
import { Observable } from "rxjs";

 @Injectable({
    providedIn : "platform"
 })
export class HomeService{
    private apiURL: string = environment.apiURL;
    constructor(private http : HttpClient){}
    public getHomePageData() : Observable<Home>{
        return this.http.get<Home>(this.apiURL + 'home');
      }
}