using Scalar.AspNetCore;
using Microsoft.AspNetCore.OpenApi;
using DevFreelaAPI.Models;
using DevFreelaAPI.Services;
using DevFreelaAPI.ExceptionHandler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Registra e configura a classe FreelanceCostConfig, vinculando suas propriedades à seção "FreelanceCostConfig" do appsettings.json.
builder.Services.Configure<FreelanceCostConfig>(
    builder.Configuration.GetSection("FreelanceCostConfig")
    );

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IConfigService, ConfigService>();

builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
