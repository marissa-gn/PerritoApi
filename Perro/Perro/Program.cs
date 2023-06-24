using Perro.Data;
using Perro.Services;
using Perro.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ISexoServicio, SexoServicio>();
builder.Services.AddTransient<INombreServicio, NombreServicio>();
builder.Services.AddTransient<IRazaServicio, RazaServicio>();
builder.Services.AddDbContext<PerroContext>(x => x.UseSqlServer(@"Server=DESKTOP-3SC43RA;Database=Perro;user=marissa;pwd=3312marissa;Encrypt=False;Trusted_Connection=True;"));
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
