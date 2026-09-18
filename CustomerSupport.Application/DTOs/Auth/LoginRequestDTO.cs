using System.ComponentModel.DataAnnotations;
namespace CustomerSupport.Application.DTOs.Auth
{
    public sealed record LoginRequestDTO
    {
        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get; init; } = string.Empty;

        [Required]
        public string Password { get; init; } = string.Empty;
    }
}
