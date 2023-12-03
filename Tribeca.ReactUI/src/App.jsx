import { useState } from "react";
import Clients from "./Components/Clients";
import "./App.css";

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Clients />

      <p>Clients App</p>
    </>
  );
}

export default App;
