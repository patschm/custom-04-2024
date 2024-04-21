using Catalog = ACME.Domain.Catalog.Products;
using Reviews = ACME.Domain.Reviews;
using DB = ACME.Database.EntityFramework.Entities;

namespace ACME.Database.EntityFramework.Mapping;

internal static class ApplicationMap
{
    internal static DB.Brand ToEntityBrand(this Catalog.Brand brand)
    {
        return new DB.Brand { Id = brand.Id, Name = brand.Name.Value, WebSite = brand.WebSite.Value, Timestamp= brand.Timestamp };
    }
    internal static DB.Product ToEntityProduct(this Catalog.Product product)
    {
        return new DB.Product { Id = product.Id, Name = product.Name.Value, Image = product.Image.Value, Timestamp = product.Timestamp };
    }
    internal static DB.ProductGroup ToEntityProductGroup(this Catalog.ProductGroup pg)
    {
        return new DB.ProductGroup { Id = pg.Id, Name = pg.Name.Value, Image = pg.Image.Value, Timestamp = pg.Timestamp };
    }
    internal static DB.Reviewer ToEntityReviewer(this Reviews.Reviewers.Reviewer rv)
    {
        return new DB.Reviewer { Id = rv.Id, Name = rv.Name.Value, Email=rv.Email.Value, UserName = rv.UserName.Value, Timestamp = rv.Timestamp };
    }
    internal static DB.Review ToEntityReview(this Reviews.Reviews.Review rv)
    {
        return new DB.Review { Id = rv.Id, Score=(byte)rv.Score.Value, Text=rv.Text, ProductId=rv.ProductId, ReviewerId=rv.ReviewerId , Timestamp = rv.Timestamp };
    }

    internal static Catalog.Brand ToDomainBrand(this DB.Brand brand)
    {
        return Catalog.Brand.Create(brand.Id, brand.Name, brand.WebSite);
    }
    internal static Catalog.Product ToDomainProduct(this DB.Product product)
    {
        var productGroup = Catalog.ProductGroup.Create(product.ProductGroup.Id, product.ProductGroup.Name, product.ProductGroup.Image);
        var brand = Catalog.Brand.Create(product.Brand.Id, product.Brand.Name, product.Brand.WebSite);
        return Catalog.Product.Create(product.Id, product.Name, brand, productGroup, product.Image);
    }
    internal static Catalog.ProductGroup ToDomainProductGroup(this DB.ProductGroup pg)
    {
        return Catalog.ProductGroup.Create(pg.Id, pg.Name, pg.Image);
    }
    internal static Reviews.Reviewers.Reviewer ToDomainReviewer(this DB.Reviewer rv)
    {
        return Reviews.Reviewers.Reviewer.Create(rv.Id, rv.Name, rv.Email, rv.UserName, rv.PasswordHash);
    }
    internal static Reviews.Reviews.Review ToDomainReview(this DB.Review rv)
    {
        return Reviews.Reviews.Review.Create(rv.Id, rv.ProductId, rv.ReviewerId, rv.Score, rv.Text);
    }
}
