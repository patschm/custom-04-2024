namespace ACME.Api.Catalog.DTO;

public class ProductDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public string? Brand { get; set; }
    public string? ProductGroup { get; set; }
}
