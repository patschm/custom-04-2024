using ACME.Api.Catalog.Mapping;
using ACME.Api.Reviews.DTO;
using ACME.Application.Reviews.Queries;
using ACME.Application.Reviews.Review.Commands;
using ACME.Database.EntityFramework;
using ACME.Domain.Abstractions.Parameters;
using ACME.Domain.Reviews.Reviews;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkRepositories(builder.Configuration);
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssemblies(
        ACME.Application.Reviews.AssemblyReference.Assembly,
        ACME.Database.EntityFramework.AssemblyReference.Assembly
        );
});
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<ReviewsProfile>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/reviews", async ([FromServices] ISender sender, [FromServices] IMapper mapper, [FromQuery] int page = 1, [FromQuery] int count = 10) =>
{
    var result = await sender.Send(new GetReviewsCommand(new PagingParameters(page, count)));
    return Results.Ok(mapper.ProjectTo<ReviewDTO>(result.AsQueryable()));
})
.WithName("GetReviews")
.WithOpenApi();

app.MapGet("/reviews/{id:long}", async ([FromServices] ISender sender, [FromServices] IMapper mapper, [FromRoute] long id) =>
{
    var result = await sender.Send(new GetReviewCommand(id));
    return Results.Ok(mapper.Map<ReviewDTO>(result));
})
.WithName("GetReview")
.WithOpenApi();


app.MapPost("/reviews", async ([FromServices]ISender sender, [FromServices] IMapper mapper, [FromBody]ReviewDTO dto) =>
{
    var review = mapper.Map<Review>(dto);
    await sender.Send(new CreateReviewCommand(dto.ProductId, dto.ReviewerId, review.Score, review.Text));
    return Results.Created();

})
.WithName("PostReview")
.WithOpenApi();

app.Run();

