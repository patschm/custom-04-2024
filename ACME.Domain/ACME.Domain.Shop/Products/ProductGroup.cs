using ACME.Domain.Abstractions;
using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Domain.Catalog.Products;

public class ProductGroup : Entity
{
    private ProductGroup(long id, Name name, Image image) : base(id)
    {
        Name = name;
        Image = image;
    }

    public Name Name { get; private set; }
    public Image Image { get; private set; }

    public static ProductGroup Create(long id, Name name, Image image)
    {
        return new ProductGroup(id, name, image);
    }
}
