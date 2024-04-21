using ACME.Domain.Abstractions.ValueObjects;
using ACME.Domain.Catalog.Products;
using MediatR;

namespace ACME.Application.Catalog.Products.Commands;

public record CreateProductCommand(
    Brand Brand, 
    ProductGroup ProductGroup, 
    Name Name, 
    string? Image) : IRequest;
