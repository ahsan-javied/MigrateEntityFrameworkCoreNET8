// Example: Creating a UserRepository class the file is kept in Models Folder in Project MigrateEntityFrameworkCoreNET8.Domain

namespace MigrateEntityFrameworkCoreNET8.Infrastructure.Domain.Models;
public record Order
{
    [Key]
    public Guid Id { get; init; }

    public Guid UserId { get; init; }

    [ForeignKey("UserId")]
    public required User User { get; init; }

    [Required]
    public string ProductName { get; init; } = string.Empty;

    [Required, Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
    public decimal Price { get; init; }

    [Required]
    public DateTime OrderDate { get; init; }

}
