import { Injectable } from "@angular/core";
import { Category } from "../Models/category.model";
import { HttpClient } from "@angular/common/http";
import { environment } from "../../environment/environment";
import { Observable } from "rxjs";

//category service is required currently in dishes page hence will be injected at dishes module file.
@Injectable(
    {
        providedIn: "platform"
    }
)
export class CategoryService{
    constructor(private http: HttpClient){}
    private apiURL = environment.apiURL + "category";

    public getCategories(): Observable<Category[]>{
        return this.http.get<Category[]>(this.apiURL);
    }
}