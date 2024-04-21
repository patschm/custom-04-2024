using ACME.Api.Catalog.DTO;
using ACME.Domain.Catalog.Products;
using AutoMapper;

namespace ACME.Api.Catalog.Mapping;

public class CatalogProfile : Profile
{
    public CatalogProfile()
    {
        CreateMap<Brand, BrandDTO>()
            .ForMember(o => o.Name, opt => opt.MapFrom(x => x.Name.Value))
            .ForMember(o => o.WebSite, opt => opt.MapFrom(x => x.WebSite.Value))
            .ReverseMap();
        CreateMap<Product, ProductDTO>()
            .ForMember(o => o.Name, opt => opt.MapFrom(x => x.Name.Value))
            .ForMember(o => o.Image, opt => opt.MapFrom(opt => opt.Image.Value))
            .ForMember(o => o.Brand, opt => opt.MapFrom(opt => opt.Brand.Name.Value))
            .ForMember(o => o.ProductGroup, opt => opt.MapFrom(opt => opt.ProductGroup.Name.Value));
        CreateMap<ProductGroup, ProductGroupDTO>()
            .ForMember(o => o.Name, opt => opt.MapFrom(x => x.Name.Value))
            .ForMember(o => o.Image, opt => opt.MapFrom(opt => opt.Image.Value));
    }
}
