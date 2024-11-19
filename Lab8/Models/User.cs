using System.ComponentModel.DataAnnotations;

namespace Lab8.Models;

public record User : Model
{
    [Required]
    [StringLength(15, ErrorMessage = "First name cannot exceed 15 characters.")]
    public required string FirstName { get; init; }

    [Required]
    [StringLength(15, ErrorMessage = "Last name cannot exceed 15 characters.")]
    public required string LastName { get; init; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public required string Email { get; init; }

    [Required] public required DateTimeOffset DateOfBirth { get; init; }

    [Required] public required string PasswordHash { get; init; }

    public required DateTimeOffset LastLoginAt { get; init; }

    public required int FailedLoginAttempts { get; init; }
}
