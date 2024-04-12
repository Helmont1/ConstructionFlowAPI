import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Construction } from "../_models/construction.model";
import { User } from "../_models/user.model";

@Injectable(
  { providedIn: 'root' }
)
export class ConstructionService {
  url = 'Construction'

  constructor(private http: HttpClient) { }

  getConstructionsByUser(user: User) {
    console.log(`${JSON.stringify(user)}`);
    return this.http.get(`${this.url}/users/${user.id}`);
  }

  createConstruction(construction: Construction) {
    return this.http.post(this.url, construction);
  }

  editConstruction(construction: Construction) {
    return this.http.put(`${this.url}/${construction.id}`, construction);
  }

  deleteConstruction(id: number) {
    return this.http.delete(`${this.url}/${id}`);
  }
}
