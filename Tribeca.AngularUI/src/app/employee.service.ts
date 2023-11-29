import { Injectable } from "@angular/core";
import { Employee } from "./employee";

@Injectable({
  providedIn: "root",
})
export class EmployeeService {
  url = "https://localhost:7264/api/Employees";

  constructor() {}
  async getAllEmployees(): Promise<Employee[]> {
    const data = await fetch(this.url);
    return (await data.json()) ?? [];
  }
}
