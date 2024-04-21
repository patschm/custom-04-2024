namespace ACME.Domain.Catalog.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(long id) : base($"Product with Id {id} does not exist")
    {
        
    }
}
