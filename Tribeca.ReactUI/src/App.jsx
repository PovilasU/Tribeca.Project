import { useState, useEffect } from "react";
import Clients from "./Components/Clients";
import "./App.css";
import About from "./Components/About";
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <div id="wrapper">
        <header className="module">
          <h1 id="logo">Clients App</h1>
          <nav>
            <Link to="/">App</Link>
            <Link to="/about">About</Link>
          </nav>
        </header>
        <main>
          <Routes>
            <Route
              path="/"
              element={
                <>
                  <Clients />
                </>
              }
            />
            <Route path="/about" element={<About />} />
          </Routes>
        </main>
        <footer>
          <p>Author: Povilas Urbonas</p>
          &copy; 2023
        </footer>
      </div>
    </BrowserRouter>
  );
}

export default App;
