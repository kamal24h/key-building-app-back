using DataAccess.Interface;

namespace LuxShop.DataAccess;

public class UnitOfWork : IDisposable, IUnitOfWork
{
    #region ctor

    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    #endregion

    #region Repositories

    private ISysUserRepository _sysUserRepository;
    public ISysUserRepository SysUserRepository =>
        _sysUserRepository = new SysUserRepository(_dbContext);

    private IAccAccountRepository _accountRepository;
    public IAccAccountRepository AccAccountRepository =>
        _accountRepository = new AccAccountRepository(_dbContext);

    private IAccAccountGroupRepository _accountGroupRepository;
    public IAccAccountGroupRepository AccAccountGroupRepository =>
        _accountGroupRepository = new AccAccountGroupRepository(_dbContext);

    private IAccAccountMainRepository _accountMainRepository;
    public IAccAccountMainRepository AccAccountMainRepository =>
        _accountMainRepository = new AccAccountMainRepository(_dbContext);

    private IAccAccountSpecificRepository _accountSpecificRepository;
    public IAccAccountSpecificRepository AccAccountSpecificRepository =>
        _accountSpecificRepository = new AccAccountSpecificRepository(_dbContext);

    private ICrmCustomerRepository _customerRepository;
    public ICrmCustomerRepository CrmCustomerRepository =>
        _customerRepository = new CrmCustomerRepository(_dbContext);

    private ICrmVendorRepository _srmVendorRepository;
    public ICrmVendorRepository  CrmVendorRepository  => 
        _srmVendorRepository = new CrmVendorRepository(_dbContext);
   
    /// <summary>
    /// Inventory Repositories
    /// </summary>
    private IInvItemRepository _invItemRepository;
    public IInvItemRepository InvItemRepository =>
        _invItemRepository = new InvItemRepository(_dbContext);

    private IInvWarehouseRepository _invWarehouseRepository;
    public IInvWarehouseRepository InvWarehouseRepository =>
        _invWarehouseRepository = new InvWarehouseRepository(_dbContext);

    private IInvItemCategoryRepository _invItemCategoryRepository;
    public IInvItemCategoryRepository InvItemCategoryRepository =>
        _invItemCategoryRepository = new InvItemCategoryRepository(_dbContext);

    private IInvItemAttachmentRepository _invItemAttachmentRepository;
    public IInvItemAttachmentRepository InvItemAttachmentRepository =>
        _invItemAttachmentRepository = new InvItemAttachmentRepository(_dbContext);

    private IInvUnitRepository _unitRerpository;
    public IInvUnitRepository InvUnitRepository =>
        _unitRerpository = new InvUnitRepository(_dbContext);

    private ICrmVendorTypeRepository _crmVendorTypeRepository;
    public ICrmVendorTypeRepository CrmVendorTypeRepository =>
        _crmVendorTypeRepository = new CrmVendorTypeRepository(_dbContext);

    private IComboRepository _comboRepository;
    public IComboRepository ComboRepository =>
        _comboRepository = new ComboRepository(_dbContext);

    private IAccCostCenterRepository _costCenterRepository;
    public IAccCostCenterRepository AccCostCenterRepository =>
        _costCenterRepository = new AccCostCenterRepository(_dbContext);

    private IAccIncomeRepository _accIncomeRepository;
    public IAccIncomeRepository AccIncomeRepository =>
        _accIncomeRepository = new AccIncomeRepository(_dbContext);

    private IAccIncomeTypeRepository _accIncomeTypeRepository;
    public IAccIncomeTypeRepository AccIncomeTypeRepository =>
        _accIncomeTypeRepository = new AccIncomeTypeRepository(_dbContext);


    private IAccExpenseRepository _accExpenseRepository;
    public IAccExpenseRepository AccExpenseRepository =>
        _accExpenseRepository = new AccExpenseRepository(_dbContext);

    private IAccExpenseTypeRepository _accExpenseTypeRepository;
    public IAccExpenseTypeRepository AccExpenseTypeRepository =>
        _accExpenseTypeRepository = new AccExpenseTypeRepository(_dbContext);

    private IInvItemPropertiesRepository _invItemPropertiesRepository;
    public IInvItemPropertiesRepository InvItemPropertiesRepository =>
        _invItemPropertiesRepository = new InvItemPropertiesRepository(_dbContext);

    private IInvCategoryPropertiesRepository _invCategoryPropertiesRepository;
    public IInvCategoryPropertiesRepository InvCategoryPropertiesRepository =>
        _invCategoryPropertiesRepository = new InvCategoryPropertiesRepository(_dbContext);

    private IAccCurrencyRepository _accCurrencyRepository;
    public IAccCurrencyRepository AccCurrencyRepository =>
        _accCurrencyRepository = new AccCurrencyRepository(_dbContext);

    private IAccCurrencyRateRepository _accCurrencyRateRepository;
    public IAccCurrencyRateRepository AccCurrencyRateRepository =>
        _accCurrencyRateRepository = new AccCurrencyRateRepository(_dbContext);

    private IAccSaleRepository _accSaleRepository;
    public IAccSaleRepository AccSaleRepository =>
        _accSaleRepository = new AccSaleRepository(_dbContext);

    private ICrmInvoiceRepository _crmInvoiceRepository;
    public ICrmInvoiceRepository CrmInvoiceRepository =>
        _crmInvoiceRepository = new CrmInvoiceRepository(_dbContext);

    private ICrmInvoiceDetailRepository _crmInvoiceDetailRepository;
    public ICrmInvoiceDetailRepository CrmInvoiceDetailRepository =>
        _crmInvoiceDetailRepository = new CrmInvoiceDetailRepository(_dbContext);

    private ICrmInvoiceTypeRepository _crmInvoiceTypeRepository;
    public ICrmInvoiceTypeRepository CrmInvoiceTypeRepository =>
        _crmInvoiceTypeRepository = new CrmInvoiceTypeRepository(_dbContext);

    private ICrmPurchaseDetailRepository _purchaseDetailRepository;
    public ICrmPurchaseDetailRepository CrmPurchaseDetailRepository =>
        _purchaseDetailRepository = new CrmPurchaseDetailRepository(_dbContext);

    private ICrmPurchaseRepository _purchaseRepository;
    public ICrmPurchaseRepository CrmPurchaseRepository =>
        _purchaseRepository = new CrmPurchaseRepository(_dbContext);

    private ISysDocumentRepository _sysDocumentRepository;
    public ISysDocumentRepository SysDocumentRepository =>
        _sysDocumentRepository = new SysDocumentRepository(_dbContext);

    private ISysDocumentSerialRepository _sysDocumentSerialRepository;
    public ISysDocumentSerialRepository SysDocumentSerialRepository =>
        _sysDocumentSerialRepository = new SysDocumentSerialRepository(_dbContext);

    private IInvTransactionRepository _invTransactionRepository;
    public IInvTransactionRepository InvTransactionRepository =>
        _invTransactionRepository = new InvTransactionRepository(_dbContext);

    private IInvTransactionDetailRepository _invTransactionDetailRepository;
    public IInvTransactionDetailRepository InvTransactionDetailRepository =>
        _invTransactionDetailRepository = new InvTransactionDetailRepository(_dbContext);

    private ICrmBrandRepository _brandRepository;
    public ICrmBrandRepository CrmBrandRepository =>
        _brandRepository = new CrmBrandRepository(_dbContext);

    private IAccEventRepository _eventRepository;
    public IAccEventRepository AccEventRepository =>
        _eventRepository = new AccEventRepository(_dbContext);

    private IAccEventTypeRepository _eventTypeRepository;
    public IAccEventTypeRepository AccEventTypeRepository =>
        _eventTypeRepository = new AccEventTypeRepository(_dbContext);

    private IAccEventDetailRepository _eventDetailRepository;
    public IAccEventDetailRepository AccEventDetailRepository =>
        _eventDetailRepository = new AccEventDetailRepository(_dbContext);



    #endregion

    #region Interface Implementation

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        var result = await _dbContext.SaveChangesAsync();
        return result;
        //try
        //{
        //    using var transaction = _dbContext.Database.BeginTransaction();
        //    var result = await _dbContext.SaveChangesAsync();
        //    transaction.Commit();
        //    return result;
        //}
        //catch (Exception ex)
        //{

        //    return 0;
        //}
    }

    public void RejectChanges()
    {
        foreach (var entity in _dbContext.ChangeTracker.Entries())
        {
            switch (entity.State)
            {
                case EntityState.Modified:
                case EntityState.Deleted:
                    entity.State = EntityState.Modified; //revert changes made to deleted entity
                    entity.State = EntityState.Unchanged;
                    break;
                case EntityState.Added:
                    entity.State = EntityState.Detached;
                    break;
                case EntityState.Detached:
                    break;
                case EntityState.Unchanged:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    #endregion

    #region Dispose & Garbage Collection

    private bool _disposing = false;

    protected virtual void Dispose(bool disposing)
    {
        if (_disposing) return;
        if (disposing)
            _dbContext.Dispose();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    #endregion
}
