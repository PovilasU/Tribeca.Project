import { Injectable } from "@angular/core";
import { Devmagic } from "./devmagic";

@Injectable({
  providedIn: "root",
})
export class DevMagicService {
  url = "https://localhost:7264/api/DevMagic";

  constructor() {}
  async getDevmagic(): Promise<Devmagic> {
    const data = await fetch(this.url);

    return (await data.text()) ?? "";
  }
}
