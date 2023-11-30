import { Component, inject } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ClientsComponent } from "../clients/clients.component";
import { EmployeesComponent } from "../employees/employees.component";
import { Client } from "../client";
import { Office } from "../client";
import { Employee } from "../employee";
import { Devmagic } from "../devmagic";
import { RouterModule } from "@angular/router";
import { ClientsService } from "../clients.service";
import { EmployeeService } from "../employee.service";
import { DevMagicService } from "../dev-magic.service";

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
      <section class="results">
        <h2>Clients</h2>
        <table border="1">
          <thead>
            <tr>
              <th>Name</th>
              <th>Offices</th>
              <th>Employees</th>
            </tr>
          </thead>
          <tbody>
            <tr *ngFor="let client of clientList">
              <td>{{ client.name }}</td>
              <td>
                <ul>
                  <li *ngFor="let office of client.offices">
                    {{ office.address }}
                    {{ office.isHeadOffice && "(Head Office)" }}
                  </li>
                </ul>
              </td>
              <td>
                <ul>
                  <li *ngFor="let office of client.offices">
                    {{ office.employeeName }}, Star Sign:
                    {{ starSignById(office.employeeId) }}, Bio as Dev Magic:
                    {{ devMagicBio(office.employeeId) }}
                  </li>
                </ul>
              </td>
            </tr>
          </tbody>
        </table>

        <h2>DevMagic to English</h2>
        <h3>{{ devmagic }}</h3>

        <!--TODO possible improvements 
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
  devmagic: Devmagic = "";
  clientsService: ClientsService = inject(ClientsService);
  employeeService: EmployeeService = inject(EmployeeService);
  devmagicService: DevMagicService = inject(DevMagicService);

  starSignById(id: any) {
    return this.employeeList.find((office) => office.employeeId === id)
      ?.starSign;
  }
  devMagicBio(id: any) {
    let bio = this.employeeList.find(
      (office) => office.employeeId === id
    )?.bioAsDevMagic;

    if (bio) {
      return bio?.charAt(0).toUpperCase() + bio.slice(1);
    } else {
      return "";
    }
  }
  constructor() {
    this.clientsService.getAllClients().then((clientlientList: Client[]) => {
      this.clientList = clientlientList;
    });
    this.employeeService.getAllEmployees().then((employeeList: Employee[]) => {
      this.employeeList = employeeList;
    });
    this.devmagicService.getDevmagic().then((devmagic: Devmagic) => {
      this.devmagic = devmagic;
    });
    const starSign = this.employeeList.find(
      (office) => office.employeeId === 1
    )?.starSign;
  }
}
