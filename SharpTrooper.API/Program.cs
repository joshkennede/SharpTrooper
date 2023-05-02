using Microsoft.Extensions.DependencyInjection;

using SharpTrooper.API.Manager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IServicesManager>(i => new ServicesManager(string.Empty));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
