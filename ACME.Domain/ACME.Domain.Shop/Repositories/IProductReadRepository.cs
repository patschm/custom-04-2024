using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Catalog.Products;

namespace ACME.Domain.Catalog.Repositories;

public interface IProductReadRepository
{
    public Task<Product> GetAsync(long id);
    public Task<IEnumerable<Product>> GetAllAsync(PagingParameters paging);
}
