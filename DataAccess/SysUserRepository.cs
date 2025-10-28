using Domain.Models;
using LuxShop.DataAccessContract;
using LuxShop.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LuxShop.DataAccess;

public class SysUserRepository : ISysUserRepository
{
    private readonly AppDbContext _dbContext;

    public SysUserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }   

    #region Read

   
    public async Task<List<AppUser>> Get()
    {
        var result = await _dbContext.AppUsers.ToListAsync();
        return result;
    }    
    public async Task<AppUser> GetByGuidAsync(Guid id)
    {
        var result = await _dbContext.AppUsers.Where(a => a.Id == id.ToString()).SingleAsync();
        return result;
    }

    public AppUser GetByGuid(Guid id)
    {
        var result = _dbContext.AppUsers.Where(a => a.Id == id.ToString()).Single();
        return result;
    }

    #endregion


    #region Internal

    #endregion
}