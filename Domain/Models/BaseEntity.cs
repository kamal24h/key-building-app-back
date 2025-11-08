namespace Domain.Models
{
    public class BaseEntity
    {       
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
