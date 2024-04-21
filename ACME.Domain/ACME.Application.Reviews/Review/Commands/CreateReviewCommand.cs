using ACME.Domain.Reviews.Reviews;
using MediatR;

namespace ACME.Application.Reviews.Review.Commands;

public record CreateReviewCommand(long productId, long reviewerId, Score Score, string? Text) : IRequest;
