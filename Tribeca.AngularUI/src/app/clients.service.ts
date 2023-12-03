import { Injectable } from "@angular/core";
import { Client } from "./client";

@Injectable({
  providedIn: "root",
})
export class ClientsService {
  urlOld = "http://localhost:3000/clients";
  url = "https://localhost:7264/api/Clients";

  constructor() {}

  async getAllClients(): Promise<Client[]> {
    try {
      const data = await fetch(this.url);
      if (!data.ok) {
        throw new Error(`HTTP error! Status: ${data.status}`);
      }
      return (await data.json()) || [];
    } catch (error) {
      console.error("Error fetching clients:", error);
      return [];
    }
  }

  async getClienById(id: number): Promise<Client | undefined> {
    console.log("i was fired");
    console.log(`${this.url}/${id}`);
    try {
      const data = await fetch(`${this.url}/${id}`);

      if (!data.ok) {
        throw new Error(`HTTP error! Status: ${data.status}`);
      }
      console.log("i was fired1");
      console.log(await data.json());
      console.log("i was fired2");
      //return await data.json();
      return (await data.json()) || [];
    } catch (error) {
      console.error("Error fetching client by ID:", error);
      return undefined;
    }
  }
}
