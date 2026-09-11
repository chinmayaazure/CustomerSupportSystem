using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSupport.Domain.Entities
{
    public sealed class Product : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

