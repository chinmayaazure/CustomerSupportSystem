namespace CustomerSupport.Domain.Entities
{
    public sealed class FAQ : BaseEntity<int>
    {
        public int? ProductId { get; set; } //Foreign key to Product entity
        public Product? Product { get; set; } //Navigation property to Product entity
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;        
        public bool IsActive { get; set; } = true;
        
    }
}
