import { Component, inject } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ClientsComponent } from "../clients/clients.component";
import { EmployeesComponent } from "../employees/employees.component";
import { Client } from "../client";
import { Employee } from "../employee";
import { RouterModule } from "@angular/router";
import { ClientsService } from "../clients.service";
import { EmployeeService } from "../employee.service";

@Component({
  selector: "app-home",
  standalone: true,
  imports: [
    CommonModule,
    ClientsComponent,
    EmployeesComponent,
    HomeComponent,
    RouterModule,
  ],
  template: `
    <section>
      <!-- <form>
        <input type="text" placeholder=" filter" />
        <button class="primary" type="buton">Search</button>
      </form> -->
      <section class="results">
        <h2>Clients</h2>
        <table border="1">
          <tr>
            <th>clientId</th>
            <th>Name</th>
            <th>officeID</th>
            <th>address</th>
            <th>isHeadOffice</th>
            <th>employeeID</th>
            <th>employeeName</th>
          </tr>
          <tr *ngFor="let client of clientList">
            <td>{{ client.clientId }}</td>
            <td>{{ client.name }}</td>
            <td>{{ client.officeID }}</td>
            <td>{{ client.address }}</td>
            <td>{{ client.isHeadOffice }}</td>
            <td>{{ client.employeeID }}</td>
            <td>{{ client.employeeName }}</td>
          </tr>
        </table>

        <h2>Employees</h2>
        <table border="1">
          <tr>
            <th>employeeId</th>
            <th>Name</th>
            <th>starSign</th>
            <th>bioAsDevMagic</th>
          </tr>

          <tr *ngFor="let employee of employeeList">
            <td>{{ employee.employeeId }}</td>
            <td>{{ employee.employeeName }}</td>
            <td>{{ employee.starSign }}</td>
            <td>{{ employee.bioAsDevMagic }}</td>
          </tr>
        </table>

        <h2>DevMagic to English</h2>
        <!--TODO fix component
          
        <app-employees
        *ngFor="let employee of employeeList"
        [employee]="employee"
      >
      </app-employees> -->

        <!-- <app-clients *ngFor="let client of clientList" [client]="client">
        </app-clients> -->
      </section>
    </section>
  `,
  styleUrls: ["./home.component.css"],
})
export class HomeComponent {
  clientList: Client[] = [];
  employeeList: Employee[] = [];
  clientsService: ClientsService = inject(ClientsService);
  employeeService: EmployeeService = inject(EmployeeService);
  constructor() {
    this.clientsService.getAllClients().then((clientlientList: Client[]) => {
      this.clientList = clientlientList;
    });
    this.employeeService.getAllEmployees().then((employeeList: Employee[]) => {
      this.employeeList = employeeList;
    });
  }
}
