import { Component } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ClientsComponent } from "../clients/clients.component";
import { Client } from "../client";
import { RouterModule } from "@angular/router";

@Component({
  selector: "app-home",
  standalone: true,
  imports: [CommonModule, ClientsComponent, HomeComponent, RouterModule],
  template: `
    <section>
      <form>
        <input type="text" placeholder=" filter" />
        <button class="primary" type="buton">Search</button>
      </form>
      <section class="results">
        <app-clients *ngFor="let client of ClientList" [client]="client">
        </app-clients>
      </section>
    </section>
  `,
  styleUrls: ["./home.component.css"],
})
export class HomeComponent {
  ClientList: Client[] = [
    {
      clientId: 1,
      name: "Client A",
    },
    {
      clientId: 2,
      name: "Client B",
    },
    {
      clientId: 3,
      name: "Client C",
    },
  ];
}
