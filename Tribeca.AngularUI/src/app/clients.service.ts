import { Injectable } from "@angular/core";
import { Client } from "./client";

@Injectable({
  providedIn: "root",
})
export class ClientsService {
  protected clientList: Client[] = [];

  constructor() {}
  getAllClients(): Client[] {
    return this.clientList;
  }
  getClienById(id: Number): Client | undefined {
    return this.clientList.find((client) => client.clientId === id);
  }
}
