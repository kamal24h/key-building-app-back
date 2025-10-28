using AutoMapper;
using Domain.Models.Enums;

namespace Domain.Models.Dtos
{
    public class BuildingDto : BaseDto
    {
        public long? BuildingId { get; set; }
        public Guid? BuildingGuid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TotalUnits { get; set; }
        public long? ManagerId { get; set; }        
        public BuildingStatusEnum? BuildingStatusId { get; set; }

        public override bool IsValid()
        {
            var baseValid = base.IsValid();
            //if (string.IsNullOrEmpty(Code))
            //    _validationMessage.AppendLine("کد کالا باید وارد شود.");
            //if (string.IsNullOrEmpty(Title))
            //    _validationMessage.AppendLine("عنوان کالا باید وارد شود.");
            var result = _validationMessage.ToString() == string.Empty && baseValid;
            return result;
        }

        public override void PrepareDto(Guid currentUserId)
        {
            base.PrepareDto(currentUserId);
            if (BuildingId.GetValueOrDefault() == 0) // Create
            {
                BuildingGuid = Guid.NewGuid();
                CreatedAt = DateTime.Now;
                //CreatedBy = currentUserId;
                //Version ??= 1;
                //LastAuditDate ??= DateTime.Now;
            }
            else // Update
            {
                ModifiedAt = DateTime.Now;
                //ModifiedBy = currentUserId;
                //Version ??= 1;
                //LastAuditDate ??= DateTime.Now;
            }
        }

        public static void ConfigureMapper(Profile mProfile)
        {
            mProfile.CreateMap<BuildingDto, Building>();
            //.ForMember(d => d.Images, opt => opt.Ignore())
            //.AfterMap(UpdateImages);
        }

    }
}
