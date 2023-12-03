import { useState } from "react";
import Clients from "./Components/Clients";
import "./App.css";

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <div id="wrapper">
        <main>
          <header className="module">
            <h1>Clients App in ReactJS</h1>
          </header>

          <section className="content">
            <Clients />
          </section>
        </main>

        <footer>
          <p>Author: Povilas Urbonas</p>
          &copy; 2023
        </footer>
      </div>
    </>
  );
}

export default App;
