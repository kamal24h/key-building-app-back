using System.Threading.Tasks;

namespace DataAccess.Interface;

public interface IUnitOfWork
{
    #region Repository Announcements

    //IAccEventTypeRepository AccEventTypeRepository { get; }
    //IAccEventDetailRepository AccEventDetailRepository { get; }
    //ISysUserRepository SysUserRepository { get; }

    #endregion

    #region Methods

    int SaveChanges();

    Task<int> SaveChangesAsync();

    void RejectChanges();

    #endregion 
}


