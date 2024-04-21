using ACME.Domain.Catalog.Products;

namespace ACME.Domain.Catalog.Repositories;

public interface IProductWriteRepository
{
    public Task CreateAsync(Product product);
}
