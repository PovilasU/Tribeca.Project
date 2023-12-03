const fetchData = async (url, setData, setLoading) => {
    try {
      const response = await fetch(url);
  
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
  
      const result = await response.json();
      setData(result);
      setLoading(false);
    } catch (error) {
      console.error("Error fetching data:", error);
      setLoading(false);
    }
  };
  
  export const fetchClients = async (setClients, setLoadingClients) => {
    await fetchData("https://localhost:7264/api/Clients", setClients, setLoadingClients);
  };
  
  export const fetchEmployees = async (setEmployees, setLoadingEmployees) => {
    await fetchData("https://localhost:7264/api/Employees", setEmployees, setLoadingEmployees);
  };
  
  export const fetchDevMagic = async (setDevMagic, setLoadingDevMagic) => {
    try {
      const response = await fetch("https://localhost:7264/api/DevMagic");
  
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
      const result = await response.text();
  
      setDevMagic(result);
      setLoadingDevMagic(false);
    } catch (error) {
      console.error("Error fetching DevMagic data:", error);
      setLoadingDevMagic(false);
    }
  };