using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Catalog.Repositories;
using ACME.Domain.Catalog.Exceptions;
using ACME.Domain.Catalog.Products;
using Microsoft.EntityFrameworkCore;
using ACME.Database.EntityFramework.Mapping;

namespace ACME.Database.EntityFramework.Repositories;

public class ProductRepository : IProductReadRepository, IProductWriteRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task CreateAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllAsync(PagingParameters pager)
    {
        var products = _context.Products
            .Skip((pager.Page - 1) + pager.Size)
            .Take(pager.Size)
            .Select(p => p.ToDomainProduct());
        return await products.ToListAsync();
    }
    public async Task<Product> GetAsync(long id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            throw new ProductNotFoundException(id);
        }
        return product.ToDomainProduct();
    }
}
