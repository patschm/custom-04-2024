using ACME.Domain.Abstractions;
using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Domain.Catalog.Products;

public class Brand : Entity
{
    private Brand(long id, Name name, WebSite site): base(id)
    {
        Name = name;
        WebSite = site;
    }

    public Name Name { get; private set; }
    public WebSite WebSite { get; private set; }

    public static Brand Create(long id, Name name, WebSite site)
    {
        return new Brand(id, name, site);   
    }
}
