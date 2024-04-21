using ACME.Domain.Reviews.Reviews;

namespace ACME.Domain.Reviews.Repositories;

public interface IReviewWriteRepository
{
    Task CreateAsync(Review review);
}
