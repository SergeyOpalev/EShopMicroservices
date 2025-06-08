using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

var configuration = builder.Configuration;

builder.Services
    .AddApplicationServices(configuration)
    .AddInfrastructureServices(configuration)
    .AddApiServices(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline

app.UseApiServices();

if (app.Environment.IsDevelopment())
{
    await app.InitializeDatabaseAsync();
}

app.Run();
