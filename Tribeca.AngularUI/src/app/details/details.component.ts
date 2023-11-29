import { Component, inject } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ActivatedRoute } from "@angular/router";
import { ClientsService } from "../clients.service";
import { Client } from "../client";

@Component({
  selector: "app-details",
  standalone: true,
  imports: [CommonModule],
  template: ` <p>details works!{{ client?.clientId }}</p> `,
  styleUrls: ["./details.component.css"],
})
export class DetailsComponent {
  route: ActivatedRoute = inject(ActivatedRoute);
  clientsService = inject(ClientsService);
  client: Client | undefined;

  constructor() {
    const clientId = Number(this.route.snapshot.params["id"]);
    this.client = this.clientsService.getClienById(clientId);
  }
}
