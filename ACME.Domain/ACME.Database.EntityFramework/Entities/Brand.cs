namespace ACME.Database.EntityFramework.Entities;

public class Brand: Entity
{
    public string? Name { get; set; }
    public string? WebSite { get; set; }
    public ICollection<Product> Products { get; set; } = new HashSet<Product>(); 
}