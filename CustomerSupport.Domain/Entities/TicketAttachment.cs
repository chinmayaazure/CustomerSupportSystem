using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSupport.Domain.Entities
{
    public sealed class TicketAttachment : BaseEntity<int>
    {
        public int SupportTicketId { get; set; }
        public SupportTicket SupportTicket { get; set; } = null!;
        public int UploadedByUserId { get; set; } // Foreign key to the user who uploaded the attachment
        public User UploadedByUser { get; set; } = null!;// Navigation property to the user who uploaded the attachment
        public string OriginalFileName { get; set; } = string.Empty;
        public string StoredFileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public long FileSizeInBytes { get; set; }
        public string RelativePath { get; set; } = string.Empty;
        
        
    }
}

