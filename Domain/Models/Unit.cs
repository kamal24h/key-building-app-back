using Domain.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Unit : BaseEntity
    {
        [Key]
        public long UnitId { get; set; }
        public Guid UnitGuid { get; set; }
        public string Number { get; set; }

        public long BuildingId { get; set; }
        public Building Building { get; set; }
        public virtual List<Resident> Residents { get; set; }

    }
}
