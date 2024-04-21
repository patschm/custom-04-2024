using ACME.Domain.Catalog.Products;
using ACME.Domain.Catalog.Repositories;
using MediatR;

namespace ACME.Application.Catalog.Products.Queries;

public class GetProductCommandHandler : IRequestHandler<GetProductCommand, Product>
{
    private readonly IProductReadRepository _productReadRepository;

    public GetProductCommandHandler(IProductReadRepository productReadRepository)
    {
        _productReadRepository = productReadRepository;
    }

    public async Task<Product> Handle(GetProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productReadRepository.GetAsync(request.Id);
        return product;
    }
}
