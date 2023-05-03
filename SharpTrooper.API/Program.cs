using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SharpTrooper.API.Manager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IServicesManager>(i => new ServicesManager(string.Empty));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SharpTrooper", Version = "v1" });
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SharpTrooper v1");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
