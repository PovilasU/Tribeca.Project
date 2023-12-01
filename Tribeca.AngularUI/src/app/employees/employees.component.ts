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
  `,
  styleUrls: ["./employees.component.css"],
})
export class EmployeesComponent {
  @Input() employee!: Employee;
}
