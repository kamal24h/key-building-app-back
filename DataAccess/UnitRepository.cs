using DataAccess.Contract;
using Domain.Models;

namespace DataAccess
{

    public class UnitRepository : IUnitRepository
    {
        public Task<Unit> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
