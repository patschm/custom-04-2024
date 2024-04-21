using ACME.Domain.Abstractions;
using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Domain.Catalog.Products;

public class Product : AggregateRoot
{
    private Product(long id, Name name, Brand brand, ProductGroup productGroup, Image image ) : base(id)
    {
        Name = name;
        Brand = brand;
        ProductGroup = productGroup;
        Image = image;
    }

    public Name Name { get; private set; }
    public Brand Brand { get; private set; }
    public ProductGroup ProductGroup { get; private set; }
    public Image Image { get; private set; }

    public static Product Create(long id, Name name, Brand brand, ProductGroup productGroup, Image image)
    {
        return new Product(id, name, brand, productGroup, image);
    }
}
