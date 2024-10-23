namespace Domain.Models;

public class TargetCategory
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}