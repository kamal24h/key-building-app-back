using AutoMapper;
using Domain.Models.Enums;
namespace Domain.Models.Vms
{
    public class UnitVm : BaseVm
    {
        public long UnitId { get; set; }
        public Guid UnitGuid { get; set; }
        public string Number { get; set; }
        public long BuildingId { get; set; }
        public BuildingVm Building { get; set; }
        public virtual List<ResidentVm> Residents { get; set; }
        public bool Active { get; set; }


        public static void ConfigureMapper(Profile mProfile)
        {
            mProfile.CreateMap<Unit, UnitVm>()
                //.ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.ItemCategory.Title))
                //.ForMember(dest => dest.BrandTitle, opt => opt.MapFrom(src => src.Brand.Title))
            //.ForMember(dest => dest.MyMainImage, opt => opt.Ignore())
            //.ForMember(dest => dest.ImagePaths, opt => opt.Ignore())
            //.ForMember(d => d.ImagePaths, opt => opt.MapFrom<ShowEstateImageResolver>());
            ;
        }
    }
}
