namespace Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }  
    }
}