using DataAccess.Contract;
using System.Threading.Tasks;

namespace DataAccess.Interface;

public interface IUnitOfWork
{
    #region Repository Announcements

    IBuildingRepository BuildingRepository { get; }
    //IAccEventDetailRepository AccEventDetailRepository { get; }
    //ISysUserRepository SysUserRepository { get; }

    #endregion

    #region Methods

    int SaveChanges();

    Task<int> SaveChangesAsync();

    void RejectChanges();

    #endregion 
}


