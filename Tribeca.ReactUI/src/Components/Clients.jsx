import React, { useState, useEffect } from "react";
const Clients = () => {
  const [clients, setClients] = useState([]);
  const [loadingClients, setLoadingClients] = useState(true);

  const [employees, setEmployees] = useState([]);
  const [loadingEmployees, setLoadingEmployees] = useState(true);

  useEffect(() => {
    const fetchClients = async () => {
      try {
        const response = await fetch("https://localhost:7264/api/Clients");

        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const result = await response.json();
        setClients(result);
        console.log(result);
        setLoadingClients(false);
      } catch (error) {
        console.error("Error fetching clients data:", error);
        setLoadingClients(false);
      }
    };

    fetchClients();
  }, []);

  useEffect(() => {
    const fetchEmployees = async () => {
      try {
        const response = await fetch("https://localhost:7264/api/Employees");

        if (!response.ok) {
          throw new Error("Network response was not ok");
        }

        const result = await response.json();
        setEmployees(result);
        console.log(result);
        setLoadingEmployees(false);
      } catch (error) {
        console.error("Error fetching employees data:", error);
        setLoadingEmployees(false);
      }
    };

    fetchEmployees();
  }, []);

  return (
    <>
      <h1>Clients</h1>

      <div>
        {loadingClients || loadingEmployees ? (
          <p>Loading...</p>
        ) : (
          clients.map((client) => {
            const filteredEmployees = employees.filter((employee) => {
              return employee.clientID === client.clientId;
            });

            return (
              <div key={client.name}>
                <h2>{client.name}</h2>
                <h2>{client.employeeID}</h2>
                <ul>
                  {client.offices.map((office) => {
                    if (office.isHeadOffice)
                      return (
                        <li key={office.address}>
                          {office.address} (Head Office)
                        </li>
                      );
                    else return <li key={office.address}>{office.address}</li>;
                  })}
                </ul>
                <ul>
                  {filteredEmployees.map((employee) => (
                    <li key={employee.employeeId}>
                      {employee.employeeName} Star Sign: {employee.starSign}{" "}
                      Bio: {employee.bioAsDevMagic}
                    </li>
                  ))}
                </ul>
              </div>
            );
          })
        )}
      </div>
    </>
  );
};

export default Clients;
