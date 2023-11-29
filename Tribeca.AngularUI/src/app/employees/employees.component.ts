import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-employees',
  standalone: true,
  imports: [CommonModule],
  template: `
    <p>
      employees works!
    </p>
  `,
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent {

}
