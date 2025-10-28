using Domain.Models;

namespace DataAccess.Contract;

public interface IBuildingRepository : ICrudRepository<Building>
{
    Task<List<Building>> Get();
    Task<Building> GetById(long id);
    Task<Building> GetByGuid(Guid guid);
}