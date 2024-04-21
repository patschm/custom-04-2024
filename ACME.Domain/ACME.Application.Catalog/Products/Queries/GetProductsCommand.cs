
using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Catalog.Products;
using MediatR;

namespace ACME.Application.Catalog.Products.Queries;

public record GetProductsCommand(PagingParameters Pager): IRequest<IEnumerable<Product>>;
