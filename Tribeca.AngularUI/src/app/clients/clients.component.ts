import { Component } from "@angular/core";
import { CommonModule } from "@angular/common";

@Component({
  selector: "app-clients",
  standalone: true,
  imports: [CommonModule],
  template: `
    <section class="listing">
      <img class="listing-photo" />
      <h2 class="listing-heading"></h2>
      <p class="listing-location"></p>
    </section>
  `,
  styleUrls: ["./clients.component.css"],
})
export class ClientsComponent {}
