using Tribeca.WebAPI.Entities;

namespace Tribeca.WebAPI.Services.Interfaces
{
    public interface IClientService
    {
        List<Client> GetAllClients();
        List<Client> GetClientById(int id);
    }
}
