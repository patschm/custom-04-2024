using ACME.Api.Reviews.DTO;
using ACME.Domain.Reviews.Reviewers;
using ACME.Domain.Reviews.Reviews;
using AutoMapper;

namespace ACME.Api.Catalog.Mapping;

public class ReviewsProfile : Profile
{
    public ReviewsProfile()
    {
        CreateMap<Review, ReviewDTO>()
            .ForMember(o => o.Score, opt => opt.MapFrom(x => x.Score.Value))
            .ReverseMap();
            
        CreateMap<Reviewer, ReviewerDTO>()
            .ForMember(o => o.Name, opt => opt.MapFrom(x => x.Name.Value))
            .ForMember(o => o.UserName, opt => opt.MapFrom(opt => opt.UserName.Value))
            .ForMember(o => o.Email, opt => opt.MapFrom(opt => opt.Email.Value))
            .ForMember(o => o.Password, opt => opt.MapFrom(opt => opt.Password))
            .ReverseMap();
    }
}
