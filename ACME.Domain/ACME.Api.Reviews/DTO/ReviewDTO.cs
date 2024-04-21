namespace ACME.Api.Reviews.DTO;

public class ReviewDTO
{
    public long Id { get; set; }
    public string? Text { get; set; }
    public int Score { get; set; }
    public long ProductId { get; set; }
    public long ReviewerId { get; set; }
}
