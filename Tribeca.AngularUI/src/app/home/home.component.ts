import { Component } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ClientsComponent } from "../clients/clients.component";

@Component({
  selector: "app-home",
  standalone: true,
  imports: [CommonModule, ClientsComponent],
  template: `
    <section>
      <form>
        <input type="text" placeholder=" filter" />
        <button class="primary" type="buton">Search</button>
      </form>
      <section class="results">
        <app-clients> </app-clients>
      </section>
    </section>
  `,
  styleUrls: ["./home.component.css"],
})
export class HomeComponent {}
