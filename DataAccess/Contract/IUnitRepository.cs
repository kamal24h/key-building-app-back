using Domain.Models;

namespace DataAccess.Contract
{
    public interface IUnitRepository
    {
        Task<Unit> GetAsync();
    }
}
