using ACME.Database.EntityFramework.Mapping;
using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Reviews.Exceptions;
using ACME.Domain.Reviews.Repositories;
using ACME.Domain.Reviews.Reviews;
using Microsoft.EntityFrameworkCore;

namespace ACME.Database.EntityFramework.Repositories;

public class ReviewRepository : IReviewReadRepository, IReviewWriteRepository
{
    private readonly ApplicationDbContext _context;

    public ReviewRepository(ApplicationDbContext context)
    {
        _context = context;;
    }

    public async Task CreateAsync(Review review)
    {
        var dbReview = review.ToEntityReview();
        _context.Reviews.Add(dbReview);
        await _context.SaveChangesAsync();  
    }
    public async Task<IEnumerable<Review>> GetAllAsync(PagingParameters pager)
    {
        var reviews = _context.Reviews
            .Skip((pager.Page - 1) + pager.Size)
            .Take(pager.Size)
            .Select(r => r.ToDomainReview());
        return await reviews.ToListAsync();
    }

    public async Task<Review> GetAsync(long id)
    {
        var review = await _context.Reviews.FindAsync(id);
        if (review == null)
        {
            throw new ReviewNotFoundException(id);
        }
        return review.ToDomainReview();
    }
}
