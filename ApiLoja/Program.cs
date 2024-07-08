using Application.Services;
using Infrastructure.Mappings;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ConnectionContext>(x =>
    x.UseMySql("Server=localhost;Database=apilojadatabase;User=root;Password=;",
    new MySqlServerVersion(new Version(8, 0, 21)))
);

builder.Services.AddTransient<IBrandRepository, BrandRepository>();

builder.Services.AddTransient<IBrandService, BrandService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
