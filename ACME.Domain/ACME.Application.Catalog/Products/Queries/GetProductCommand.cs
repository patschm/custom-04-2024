using ACME.Domain.Catalog.Products;
using MediatR;

namespace ACME.Application.Catalog.Products.Queries;

public record GetProductCommand(long Id): IRequest<Product>;
