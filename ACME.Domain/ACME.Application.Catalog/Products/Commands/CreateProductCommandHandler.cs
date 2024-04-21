using ACME.Domain.Catalog.Products;
using ACME.Domain.Catalog.Repositories;
using MediatR;

namespace ACME.Application.Catalog.Products.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductWriteRepository _productRepository;

    public CreateProductCommandHandler(IProductWriteRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(0, request.Name, request.Brand, request.ProductGroup, request.Image);
        await _productRepository.CreateAsync(product);
    }
}
