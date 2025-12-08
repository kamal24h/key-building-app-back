using AutoMapper;
using Domain.Models.Enums;
using Domain.Models.Vms;

namespace Domain.Models.Dtos
{
    public class ResidentDto : BaseDto
    {
        public long? ResidentId { get; set; }
        public Guid? ResidentGuid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long UnitId { get; set; }
        public bool Active { get; set; }

        public override bool IsValid()
        {
            var baseValid = base.IsValid();
            if (string.IsNullOrEmpty(Family))
                _validationMessage.AppendLine("نام فامیلی ساکن باید وارد شود.");
            if (string.IsNullOrEmpty(UserName))
                _validationMessage.AppendLine("نام کاربری باید وارد شود.");
            var result = _validationMessage.ToString() == string.Empty && baseValid;
            return result;
        }

        public override void PrepareDto(Guid currentUserId)
        {
            base.PrepareDto(currentUserId);
            if (ResidentId.GetValueOrDefault() == 0) // Create
            {
                ResidentGuid = Guid.NewGuid();
                CreatedAt = DateTime.Now;              
            }
            else // Update
            {
                ModifiedAt = DateTime.Now;
            }
        }

        public static void ConfigureMapper(Profile mProfile)
        {
            mProfile.CreateMap<ResidentDto, Resident>();
            //.ForMember(d => d.Images, opt => opt.Ignore())
            //.AfterMap(UpdateImages);
        }
    }
}
