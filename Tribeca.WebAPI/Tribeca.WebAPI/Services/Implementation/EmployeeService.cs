using Tribeca.WebAPI.Context;
using Tribeca.WebAPI.Entities;
using Tribeca.WebAPI.Services.Interfaces;

namespace Tribeca.WebAPI.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private TribecaDbContext dbContext;
        public EmployeeService(TribecaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public List<Employee> GetEmployeeStarSign(string name)
        {
          
            var employee = dbContext.Employees
             .Where(e => e.Name == name).ToList();

            return employee;

        }

    }
}
