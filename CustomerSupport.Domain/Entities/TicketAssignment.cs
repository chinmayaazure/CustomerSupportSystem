namespace CustomerSupport.Domain.Entities
{
    public sealed class TicketAssignment : BaseEntity<int>
    {
        
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UnassignedAt { get; set; }

        public int SupportTicketId { get; set; }
        public SupportTicket SupportTicket { get; set; } = null!;

        public int AssignedToUserId { get; set; }
        public User AssignedToUser { get; set; } = null!;

        public int AssignedByUserId { get; set; }
        public User AssignedByUser { get; set; } = null!;
    }
}

