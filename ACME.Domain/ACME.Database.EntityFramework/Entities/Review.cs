namespace ACME.Database.EntityFramework.Entities;

public class Review: Entity
{
    public string? Text { get; set; }
    public byte Score { get; set; }
    public long ProductId { get; set; }
    public int ReviewType { get; set; } = 1;
    public long ReviewerId { get; set; }
    public Product Product { get; set; } = null!;
    public Reviewer Reviewer { get; set; } = null!;
}
