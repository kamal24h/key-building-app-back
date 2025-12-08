using DataAccess.Contract;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess;

public class ResidentRepository(AppDbContext _dbContext) : IResidentRepository
{
    
    #region Read

    public async Task<List<Resident>> Get()
    {
        var result = await _dbContext.Residents.ToListAsync();
        return result;
    }

    public async Task<Resident> GetById(long id)
    {
        var result = await _dbContext.Residents.Where(a => a.ResidentId == id).SingleAsync();
        return result;
    }

    public async Task<Resident> GetByGuid(Guid id)
    {
        var result = await _dbContext.Residents.Where(a => a.ResidentGuid == id).SingleAsync();
        return result;
    }

    public IQueryable<Resident> Where(Expression<Func<Resident, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Create

    public Resident Add(Resident entity)
    {
        _dbContext.Residents.Add(entity);
        return entity;
    }

    public async Task<Resident> AddAsync(Resident entity)
    {
        await _dbContext.Residents.AddAsync(entity);
        return entity;
    }

    #endregion

    #region Update

    public Resident Update(Resident entity)
    {
        _dbContext.Residents.Update(entity);
        return entity;
    }

    #endregion

    #region Delete

    public Resident Delete(Resident entity)
    {
        throw new NotImplementedException();
    }

    public bool DeleteBy(int id)
    {
        throw new NotImplementedException();
    }

    #endregion

    

    

    
    
    
    #region Internal

    #endregion
}