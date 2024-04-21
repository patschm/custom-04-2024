namespace ACME.Database.EntityFramework.Entities;
public class Product : Entity
{
    public string? Name { get; set; }
    public string? Image { get; set; }
    public long BrandId { get; set; }
    public long ProductGroupId { get; set; }
    public Brand Brand { get; set; } = null!;
    public ProductGroup ProductGroup { get; set; } = null!;
    public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
}