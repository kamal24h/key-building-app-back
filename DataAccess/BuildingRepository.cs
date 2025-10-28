using DataAccess.Contract;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess;

public class BuildingRepository : IBuildingRepository
{
    private readonly AppDbContext _dbContext;

    public BuildingRepository(AppDbContext dbContext) => _dbContext = dbContext;

    #region Read


    public async Task<List<Building>> Get()
    {
        var result = await _dbContext.Buildings.ToListAsync();
        return result;
    }

    public async Task<Building> GetById(long id)
    {
        var result = await _dbContext.Buildings.Where(a => a.BuildingId == id).SingleAsync();
        return result;
    }

    public async Task<Building> GetByGuid(Guid id)
    {
        var result = await _dbContext.Buildings.Where(a => a.BuildingGuid == id).SingleAsync();
        return result;
    }
    
    public Building Add(Building entity)
    {
        _dbContext.Buildings.Add(entity);
        return entity;
    }

    public async Task<Building> AddAsync(Building entity)
    {
        await _dbContext.Buildings.AddAsync(entity);
        return entity;
    }

    public Building Update(Building entity)
    {
        _dbContext.Buildings.Update(entity);
        return entity;
    }

    public Building Delete(Building entity)
    {
        throw new NotImplementedException();
    }

    public bool DeleteBy(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Building> Where(Expression<Func<Building, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    #endregion


    #region Internal

    #endregion
}