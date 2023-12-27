import { Injectable } from "@angular/core";
import { Menu } from "../Models/menu.model";
import { Observable, Subject } from "rxjs";
import { environment } from "../../environment/environment";
import { HttpClient } from "@angular/common/http";

@Injectable(
    {providedIn: "platform"}
)
export class MenuService{
    public menuSelected: Subject<Menu> = new Subject<Menu>();
    constructor(private http : HttpClient){}

    private apiURL: string = environment.apiURL;
    
    //working With API for the Home/Landing Page
    public getMenus() : Observable<Menu[]>{
      return this.http.get<Menu[]>(this.apiURL + "menu");
      //return this.menus.slice();
    }
    public getMenusByID(_id: number): Observable<Menu>{
      return this.http.get<Menu>(this.apiURL + `menu/${_id}`);
    }

    public menuSelectionChanged(id: number){
      this.getMenusByID(id).subscribe(menu => {
        this.menuSelected.next(menu);
      })
  }

}