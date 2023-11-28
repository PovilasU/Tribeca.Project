using Tribeca.WebAPI.Entities;

namespace Tribeca.WebAPI.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeeStarSign(string name);
    }
}
