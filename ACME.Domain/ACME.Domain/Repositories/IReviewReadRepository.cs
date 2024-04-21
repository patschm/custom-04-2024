using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Reviews.Reviews;

namespace ACME.Domain.Reviews.Repositories;

public interface IReviewReadRepository
{
    Task<IEnumerable<Review>> GetAllAsync(PagingParameters pager);
    Task<Review> GetAsync(long id);
}
