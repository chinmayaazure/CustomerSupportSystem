using CustomerSupport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerSupport.Domain
{
    internal class Class1
    {
        Role role = new Role
        {
            Id = Enums.RoleType.Administrator,
            Name = "Admin",
            Description = "Administrator role with full access",
            IsActive = true
        };

        TicketPriority ticketPriority = new TicketPriority
        {
            Id = Enums.TicketPriorityType.High,
            Name = "High",
            Description = "High priority ticket",
            SortOrder = 1,
            IsActive = true
        };
    }
}
