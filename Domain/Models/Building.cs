using Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Building : BaseEntity
    {
        public long BuildingId { get; set; }
        public Guid BuildingGuid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TotalUnits { get; set; }
        public long ManagerId { get; set; }
        public virtual List<Unit> Units { get; set; }
        public BuildingStatusEnum BuildingStatusId { get; set; }        
    }
}
