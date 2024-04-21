using ACME.Api.Catalog.DTO;
using ACME.Api.Catalog.Mapping;
using ACME.Application.Catalog.Products.Queries;
using ACME.Database.EntityFramework;
using ACME.Domain.Abstractions.Parameters;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEntityFrameworkRepositories(builder.Configuration);
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssemblies(
        ACME.Application.Catalog.AssemblyReference.Assembly,
        ACME.Database.EntityFramework.AssemblyReference.Assembly
        );
});
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<CatalogProfile>());

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

app.MapGet("/products", async ([FromServices]ISender sender, [FromServices]IMapper mapper, [FromQuery] int page = 1, [FromQuery] int count =10) =>
{
    var result = await sender.Send(new GetProductsCommand(new PagingParameters(page, count)));
    return Results.Ok(mapper.ProjectTo<ProductDTO>(result.AsQueryable()));
})
.WithName("GetAllProducts")
.WithOpenApi();

app.Run();

