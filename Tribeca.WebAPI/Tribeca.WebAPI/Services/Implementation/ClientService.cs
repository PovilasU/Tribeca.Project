using Tribeca.WebAPI.Context;
using Tribeca.WebAPI.Entities;
using Tribeca.WebAPI.Services.Interfaces;

namespace Tribeca.WebAPI.Services.Implementation
{
    public class ClientService : IClientService
    {
        private TribecaDbContext dbContext;
        public ClientService(TribecaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Client> GetAllClients()
        {
            var query = from c in dbContext.Clients
                        join o in dbContext.Offices on c.ClientId equals o.ClientID
                        join e in dbContext.Employees on o.OfficeID equals e.OfficeID into empGroup
                        from employee in empGroup.DefaultIfEmpty()
                        orderby c.ClientId, o.IsHeadOffice descending, employee.EmployeeID
                        select new Client
                        {
                            ClientId = c.ClientId,
                            Name = c.Name,
                            OfficeID = o.OfficeID,
                            Address = o.Address,
                            IsHeadOffice = o.IsHeadOffice,
                            EmployeeID = employee.EmployeeID,
                            EmployeeName = employee.Name
                        };

            var result = query.ToList();

            return result;
        }

        public List<Client> GetClientById(int id)
        {
            var query = from c in dbContext.Clients
                        where c.ClientId == id
                        join o in dbContext.Offices on c.ClientId equals o.ClientID
                        join e in dbContext.Employees on o.OfficeID equals e.OfficeID into empGroup
                        from employee in empGroup.DefaultIfEmpty()
                        orderby c.ClientId, o.IsHeadOffice descending, employee.EmployeeID
                        select new Client
                        {
                            ClientId = c.ClientId,
                            Name = c.Name,
                            OfficeID = o.OfficeID,
                            Address = o.Address,
                            IsHeadOffice = o.IsHeadOffice,
                            EmployeeID = employee.EmployeeID,
                            EmployeeName = employee.Name
                        };

            var result = query.ToList();

            return result;

        }
    }
}
