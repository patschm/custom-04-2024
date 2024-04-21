using ACME.Domain.Catalog.Products;
using ACME.Domain.Catalog.Repositories;
using MediatR;

namespace ACME.Application.Catalog.Products.Queries;

public record GetProductsCommandHandler : IRequestHandler<GetProductsCommand, IEnumerable<Product>>
{
    private readonly IProductReadRepository _productReadRepository;

    public GetProductsCommandHandler(IProductReadRepository productReadRepository)
    {
        _productReadRepository = productReadRepository;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsCommand request, CancellationToken cancellationToken)
    {
        return await _productReadRepository.GetAllAsync(request.Pager);
    }
}
