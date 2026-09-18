using CustomerSupport.Domain.Enums;
namespace CustomerSupport.Domain.Entities
{
    public sealed class User : BaseEntity<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public RoleType RoleId { get; set; } // this is Enum
        public bool IsActive { get; set; } = true;
        public Role Role { get; set; } = null!; //this is navigation property, contains name, description,
                                                //isActive and Id property which is of type RoleType

        public ICollection<RefreshToken> RefreshTokens { get; set; }
            = new List<RefreshToken>();
    }
}

