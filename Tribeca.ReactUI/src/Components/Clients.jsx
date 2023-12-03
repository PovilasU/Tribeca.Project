import React, { useState, useEffect } from "react";
const Clients = () => {
  const [dataClients, setDataClients] = useState([]);
  const [loadingClients, setLoadingClients] = useState(true);

  const [dataEmployees, setDataEmployees] = useState([]);
  const [loadingEmployees, setLoadingEmployees] = useState(true);

  useEffect(() => {
    const fetchDataClients = async () => {
      try {
        const response = await fetch("https://localhost:7264/api/Clients");

        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const result = await response.json();
        setDataClients(result);
        console.log(result);
        setLoadingClients(false);
      } catch (error) {
        console.error("Error fetching clients data:", error);
        setLoadingClients(false);
      }
    };

    fetchDataClients();
  }, []);

  useEffect(() => {
    const fetchDataEmployees = async () => {
      try {
        const response = await fetch("https://localhost:7264/api/Employees");

        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const result = await response.json();
        setDataEmployees(result);
        console.log(result);
        setLoadingEmployees(false);
      } catch (error) {
        console.error("Error fetching employees data:", error);
        setLoadingEmployees(false);
      }
    };

    fetchDataEmployees();
  }, []);

  return (
    <>
      <h1>Clients</h1>

      <div>
        {loadingClients || loadingEmployees ? (
          <p>Loading...</p>
        ) : (
          <ul>
            {dataClients.map((client) => (
              <li key={client.name}>{client.name}</li>
            ))}
          </ul>
        )}
      </div>
    </>
  );
};

export default Clients;
