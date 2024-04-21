
namespace ACME.Database.EntityFramework.Entities;
public class ProductGroup: Entity
{
    public string? Name { get; set; }
    public string? Image { get; set; }
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}