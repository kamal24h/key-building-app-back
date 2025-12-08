using Domain.Models;

namespace DataAccess.Contract;

public interface IResidentRepository : ICrudRepository<Resident>
{
    Task<List<Resident>> Get();
    Task<Resident> GetById(long id);
    Task<Resident> GetByGuid(Guid guid);
}