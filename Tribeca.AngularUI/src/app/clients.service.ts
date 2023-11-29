import { Injectable } from "@angular/core";
import { Client } from "./client";

@Injectable({
  providedIn: "root",
})
export class ClientsService {
  // protected clientList: Client[] = [];
  urlOld = "http://localhost:3000/clients";
  url = "https://localhost:7264/api/Clients";

  constructor() {}
  async getAllClients(): Promise<Client[]> {
    const data = await fetch(this.url);
    return (await data.json()) ?? [];
  }
  async getClienById(id: Number): Promise<Client | undefined> {
    const data = await fetch(`${this.url}/${id}`);
    return (await data.json()) ?? [];
  }
}
