namespace ACME.Domain.Reviews.Reviews;

public record Score
{
    public Score(int value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, 0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 5);
        Value = value;    
    }
    public int Value { get; init; }

    public static implicit operator Score (int value)
    {
        return new Score (value);
    }
}
