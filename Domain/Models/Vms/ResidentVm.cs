using AutoMapper;
using Domain.Models.Enums;
namespace Domain.Models.Vms
{
    public class ResidentVm : BaseVm
    {
        public long ResidentId { get; set; }
        public Guid ResidentGuid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UnitVm Unit { get; set; }
        public bool Active { get; set; }


        public static void ConfigureMapper(Profile mProfile)
        {
            mProfile.CreateMap<Resident, ResidentVm>()
                //.ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.ItemCategory.Title))
                //.ForMember(dest => dest.BrandTitle, opt => opt.MapFrom(src => src.Brand.Title))
            //.ForMember(dest => dest.MyMainImage, opt => opt.Ignore())
            //.ForMember(dest => dest.ImagePaths, opt => opt.Ignore())
            //.ForMember(d => d.ImagePaths, opt => opt.MapFrom<ShowEstateImageResolver>());
            ;
        }
    }
}
