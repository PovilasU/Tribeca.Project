import { Component, Input } from "@angular/core";
import { CommonModule } from "@angular/common";
import { Employee } from "../employee";
import { RouterModule } from "@angular/router";

@Component({
  selector: "app-employees",
  standalone: true,
  imports: [CommonModule],
  template: `
    <tr>
      <td>{{ employee.employeeId }}</td>
      <td>{{ employee.employeeName }}</td>
      <td>{{ employee.starSign }}</td>
      <td>{{ employee.bioAsDevMagic }}</td>
    </tr>

    <!-- <section class="listing">
      <h2 class="listing-heading">
        Employee ClientId: {{ employee.employeeId }}
      </h2>
      <p class="listing-location">Employee Name: {{ employee.employeeName }}</p>
      <p class="listing-location">Employee starSign: {{ employee.starSign }}</p>
      <p class="listing-location">
        Client bioAsDevMagic: {{ employee.bioAsDevMagic }}
      </p>
    </section> -->
  `,
  styleUrls: ["./employees.component.css"],
})
export class EmployeesComponent {
  @Input() employee!: Employee;
}

// export interface Employee {
//   employeeId: number;
//   officeID: number;
//   clientID: number;
//   employeeName: string;
//   bio: string;
//   dateOfBirth: string;
//   starSign: string;
//   bioAsDevMagic: string;
// }
