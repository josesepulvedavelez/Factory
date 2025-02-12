using Factory.Application.Interfaces;
using Factory.Application.Services;
using Factory.Domain.Interfaces;
using Factory.Infrastructure;
using Factory.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FactoryContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadena"));
});

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddScoped<IComicFavoritoService, ComicfavoritoService>();
builder.Services.AddScoped<IComicFavoritoRepository, ComicFavoritoRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
