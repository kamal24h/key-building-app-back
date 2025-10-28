using AutoMapper;
using Domain.Models.Enums;
namespace Domain.Models.Vms
{
    public class BuildingVm : BaseVm
    {
        public long BuildingId { get; set; }
        public Guid BuildingGuid { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int TotalUnits { get; set; }
        public long ManagerId { get; set; }
        public Resident? Manager { get; set; }
        public BuildingStatusEnum BuildingStatusId { get; set; }


        public static void ConfigureMapper(Profile mProfile)
        {
            mProfile.CreateMap<Building, BuildingVm>()
                //.ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.ItemCategory.Title))
                //.ForMember(dest => dest.BrandTitle, opt => opt.MapFrom(src => src.Brand.Title))
            //.ForMember(dest => dest.MyMainImage, opt => opt.Ignore())
            //.ForMember(dest => dest.ImagePaths, opt => opt.Ignore())
            //.ForMember(d => d.ImagePaths, opt => opt.MapFrom<ShowEstateImageResolver>());
            ;
        }
    }
}
