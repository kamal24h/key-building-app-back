using Domain.Models.Enums;

namespace Domain.Models
{
    public class ResidentDto : BaseDto
    {
        public long? ResidentId { get; set; }
        public Guid? ResidentGuid { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
