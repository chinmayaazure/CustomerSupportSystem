namespace CustomerSupport.Domain.Entities
{
    public sealed class TicketComment : BaseEntity<int>
    {
        
        public string Content { get; set; } = string.Empty;
        public bool IsInternal { get; set; }
        public int SupportTicketId { get; set; }
        public SupportTicket SupportTicket { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

