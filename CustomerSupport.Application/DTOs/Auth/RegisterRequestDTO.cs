using System.ComponentModel.DataAnnotations;

namespace CustomerSupport.Application.DTOs.Auth
{
    //public sealed class RegisterRequestDTO
    //{
    //    [Required]
    //    [StringLength(100, MinimumLength = 2)]
    //    public string FirstName { get; set; } = string.Empty;

    //    [Required]
    //    [StringLength(100, MinimumLength = 2)]
    //    public string LastName { get; set; } = string.Empty;

    //    [Required]
    //    [EmailAddress]
    //    [StringLength(256)]
    //    public string Email { get; set; } = string.Empty;

    //    [Phone]
    //    [StringLength(20)]
    //    public string? PhoneNumber { get; set; }

    //    [Required]
    //    [StringLength(100, MinimumLength = 8)]
    //    public string Password { get; set; } = string.Empty;

    //    [Required]
    //    [Compare(nameof(Password))]
    //    public string ConfirmPassword { get; set; } = string.Empty;
    //}

    

    public sealed record RegisterRequestDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; init; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; init; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get; init; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; init; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; init; } = string.Empty;

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; init; } = string.Empty;
    }
}
