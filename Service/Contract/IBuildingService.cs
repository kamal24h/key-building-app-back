using Domain.Models;
using Domain.Models.Dtos;
using Domain.Models.Vms;
using Microsoft.AspNetCore.Http;

namespace Service.Contract;

public interface IBuildingService
{
    Task<List<BuildingVm>> Get();
    Task<List<BuildingVm>> GetForReport();
    List<Building> GetForSearch();
    Task<BuildingVm> GetByIdAsync(int ItemId);
    Task<BuildingDto> GetForUpdate(int ItemId);
    Task<int> AddAsync(BuildingDto dto);
    Task<int> UpdateAsync(BuildingDto dto);
    bool DeleteById(int ItemId);
    Task<bool> InsertGalleryImage(List<IFormFile> imageGalleries, int itemId);
}
