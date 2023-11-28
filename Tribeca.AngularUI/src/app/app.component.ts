import { Component } from "@angular/core";

@Component({
  standalone: true,
  selector: "app-root",
  template: `
    <main>
      <header class="brand-name">
        <img
          class="brand-logo"
          src="/assets/Tribeca-logo-White.png"
          alt="tribeca logo"
          aria-hidden="true"
        />
      </header>
      test
    </main>
  `,
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  title = "homes";
}
