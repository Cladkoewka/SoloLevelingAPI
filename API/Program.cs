using Domain.Interfaces;
using Infrastructrure.DatabaseContext;
using Infrastructrure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddControllers();
services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<ITargetRepository, TargetRepository>();
services.AddScoped<ITargetCategoryRepository, TargetCategoryRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.MapControllers();

app.Run();