using Domain.Models;
using Domain.Models.Dtos;
using Domain.Models.Vms;
using Microsoft.AspNetCore.Http;

namespace Service.Contract;

public interface IResidentService
{
    Task<List<ResidentVm>> Get();
    Task<List<ResidentVm>> GetForReport();
    List<Resident> GetForSearch();
    Task<ResidentVm> GetByIdAsync(int ItemId);
    Task<ResidentDto> GetForUpdate(int ItemId);
    Task<int> AddAsync(ResidentDto dto);
    Task<int> UpdateAsync(ResidentDto dto);
    bool DeleteById(int ItemId);
    Task<bool> InsertGalleryImage(List<IFormFile> imageGalleries, int itemId);
}
