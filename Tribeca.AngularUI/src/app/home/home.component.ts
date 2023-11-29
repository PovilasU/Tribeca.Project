import { Component, inject } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ClientsComponent } from "../clients/clients.component";
import { Client } from "../client";
import { RouterModule } from "@angular/router";
import { ClientsService } from "../clients.service";

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
  ClientList: Client[] = [];
  clientsService: ClientsService = inject(ClientsService);
  constructor() {
    this.ClientList = this.clientsService.getAllClients();
  }
}
