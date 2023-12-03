import React, { useState, useEffect } from "react";
import { fetchClients, fetchEmployees, fetchDevMagic } from "../api";
import DevMagicToEnglish from "./DevMagicToEnglish";

const Clients = () => {
  const [clients, setClients] = useState([]);
  const [loadingClients, setLoadingClients] = useState(true);

  const [employees, setEmployees] = useState([]);
  const [loadingEmployees, setLoadingEmployees] = useState(true);

  const [devMagic, setDevMagic] = useState([]);
  const [loadingdevMagic, setLoadingDevMagic] = useState(true);

  useEffect(() => {
    fetchClients(setClients, setLoadingClients);
  }, []);

  useEffect(() => {
    fetchEmployees(setEmployees, setLoadingEmployees);
  }, []);

  useEffect(() => {
    fetchDevMagic(setDevMagic, setLoadingDevMagic);
  }, []);

  return (
    <>
      <section className="clients-table module">
        <h1>Clients</h1>

        <div>
          {loadingClients && loadingEmployees && loadingdevMagic ? (
            <p>Loading...</p>
          ) : (
            <table border="1">
              <thead>
                <tr>
                  <th>Name</th>
                  <th>Offices</th>
                  <th>Employees</th>
                </tr>
              </thead>
              <tbody>
                {clients.map((client) => {
                  const filteredEmployees = employees.filter((employee) => {
                    return employee.clientID === client.clientId;
                  });
                  return (
                    <tr key={client.name}>
                      <td>{client.name}</td>
                      <td>
                        <ul>
                          {client.offices.map((office, index) => (
                            <li key={index}>
                              {office.address}{" "}
                              {office.isHeadOffice && "(Head Office)"}
                            </li>
                          ))}
                        </ul>
                      </td>
                      <td>
                        <ul>
                          {filteredEmployees.map((employee) => (
                            <li key={employee.employeeId}>
                              {employee.employeeName} Star Sign:{" "}
                              {employee.starSign} Bio: {employee.bioAsDevMagic}
                            </li>
                          ))}
                        </ul>
                      </td>
                    </tr>
                  );
                })}
              </tbody>
            </table>
          )}
        </div>
      </section>
      <DevMagicToEnglish devMagic={devMagic} />
    </>
  );
};

export default Clients;
