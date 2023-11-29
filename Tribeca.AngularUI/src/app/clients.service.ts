import { Injectable } from "@angular/core";
import { Client } from "./client";

@Injectable({
  providedIn: "root",
})
export class ClientsService {
  protected clientList: Client[] = [
    {
      clientId: 1,
      name: "Client A",
    },
    {
      clientId: 2,
      name: "Client B",
    },
    {
      clientId: 3,
      name: "Client C",
    },
  ];

  constructor() {}
  getAllClients(): Client[] {
    return this.clientList;
  }
  getClienById(id: Number): Client | undefined {
    return this.clientList.find((client) => client.clientId === id);
  }
}
