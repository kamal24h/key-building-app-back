using Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Building : BaseEntity
    {
        [Key]
        public long BuildingId { get; set; }
        public Guid BuildingGuid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TotalUnits { get; set; }
        public long ManagerId { get; set; }
        public Resident Manager { get; set; }
        public BuildingStatusEnum BuildingStatusId { get; set; }        
    }
}
