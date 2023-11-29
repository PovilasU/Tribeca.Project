import { Component, Input } from "@angular/core";
import { CommonModule } from "@angular/common";
import { Client } from "../client";
import { RouterModule } from "@angular/router";

@Component({
  selector: "app-clients",
  standalone: true,
  imports: [CommonModule, RouterModule],
  template: `
    <section class="listing">
      <img class="listing-photo" src="" />
      <h2 class="listing-heading">ClientId: {{ client.clientId }}</h2>
      <p class="listing-location">Client Name: {{ client.name }}</p>
      <a [routerLink]="['/details', client.clientId]"> details</a>
    </section>
  `,
  styleUrls: ["./clients.component.css"],
})
export class ClientsComponent {
  @Input() client!: Client;
}
