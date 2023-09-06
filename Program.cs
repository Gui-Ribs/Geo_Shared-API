using GeoShared.Main.Configuration;
using GeoShared.Main.Repository.Bioma;
using GeoShared.Main.Repository.Continente;
using GeoShared.Main.Repository.Governador;
using GeoShared.Main.Repository.Imagem;
using GeoShared.Main.Repository.Presidente;
using GeoShared.Main.Repository.Provincia;
using GeoShared.Main.Services.Bioma;
using GeoShared.Main.Services.Continente;
using GeoShared.Main.Services.Governador;
using GeoShared.Main.Services.Imagem;
using GeoShared.Main.Services.Presidente;
using GeoShared.Main.Services.Provincia;
using Main.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string conectDb ()
{
    var connectionString = builder.Configuration.GetConnectionString("LocalhostConnection");
    if (connectionString != null)
    { 
        Console.WriteLine("Success");
        return connectionString;
    }
    return builder.Configuration.GetConnectionString("LocalhostConnection") ?? throw new InvalidOperationException("Connect string not found");

}

var takeString = conectDb();

  
builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseMySql(takeString, ServerVersion.AutoDetect(takeString))
);

builder.Services.AddScoped<IBiomaRepository, BiomaRepository>();
builder.Services.AddScoped<IBiomaService, BiomaService>();

builder.Services.AddScoped<IContinenteRepository, ContinenteRepository>();
builder.Services.AddScoped<IContinenteService, ContinenteService>();

builder.Services.AddScoped<IGovernadorRepository, GovernadorRepository>();
builder.Services.AddScoped<IGovernadorService, GovernadorService>();

builder.Services.AddScoped<IImagemRepository, ImagemRepository>();
builder.Services.AddScoped<IImagemService, ImagemService>();

builder.Services.AddScoped<IPresidenteRepository, PresidenteRepository>();
builder.Services.AddScoped<IPresidenteService, PresidenteService>();

builder.Services.AddScoped<IProvinciaRepository, ProvinciaRepository>();
builder.Services.AddScoped<IProvinciaService, ProvinciaService>();

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