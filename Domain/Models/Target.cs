namespace Domain.Models;

public class Target
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Score { get; set; }
    public int CategoryId { get; set; }
    public TargetCategory Category { get; set; }
    
    // Maybe created time
}