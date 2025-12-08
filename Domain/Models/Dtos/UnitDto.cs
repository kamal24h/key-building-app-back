using AutoMapper;
using Domain.Models.Enums;
using Domain.Models.Vms;

namespace Domain.Models.Dtos
{
    public class UnitDto : BaseDto
    {
        public long? UnitId { get; set; }
        public Guid? UnitGuid { get; set; }
        public string Number { get; set; }
        public long BuildingId { get; set; }
        public virtual List<ResidentDto> Residents { get; set; }
        public bool Active { get; set; }

        public override bool IsValid()
        {
            var baseValid = base.IsValid();
            if (BuildingId == 0)
                _validationMessage.AppendLine("ساختمان واحد باید مشخص شود.");
            //if (string.IsNullOrEmpty(Title))
            //    _validationMessage.AppendLine("عنوان کالا باید وارد شود.");
            var result = _validationMessage.ToString() == string.Empty && baseValid;
            return result;
        }

        public override void PrepareDto(Guid currentUserId)
        {
            base.PrepareDto(currentUserId);
            if (UnitId.GetValueOrDefault() == 0) // Create
            {
                UnitGuid = Guid.NewGuid();
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
            mProfile.CreateMap<UnitDto, Unit>();
            //.ForMember(d => d.Images, opt => opt.Ignore())
            //.AfterMap(UpdateImages);
        }

    }
}
