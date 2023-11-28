using Tribeca.WebAPI.Context;
using Tribeca.WebAPI.Entities;
using Tribeca.WebAPI.Services.Interfaces;

namespace Tribeca.WebAPI.Services.Implementation
{
    public class OfficeService : IOfficeService
    {
        private TribecaDbContext dbContext;
        public OfficeService(TribecaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Office> GetAllOffices()
        {
            return dbContext.Offices.ToList();
        }
    }
}
