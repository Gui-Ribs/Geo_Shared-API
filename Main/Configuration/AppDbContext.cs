using Main.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace GeoShared.Main.Configuration;

public class AppDbContext : DbContext
{
    public DbSet<BiomaModel> Biomas { get; set; }

    public DbSet<ContinenteModel> Continentes { get; set; }

    public DbSet<GovernadorModel> Governadores { get; set; }

    public DbSet<ImagemModel> Imagens { get; set; }

    public DbSet<PresidenteModel> Presidentes { get; set; }

    public DbSet<ProvinciaModel> Provincias { get; set; }

    public DbSet<QuizModel> Quiz { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder builder)
    { 
        base.OnModelCreating(builder);

        builder.Entity<ContinenteModel>()
        .HasOne<BiomaModel>()
        .WithMany()
        .HasForeignKey("bioma");

        builder.Entity<ProvinciaModel>()
        .HasOne<BiomaModel>()  
        .WithMany()           
        .HasForeignKey("bioma");

        builder.Entity<GovernadorModel>()
        .HasOne<ProvinciaModel>()
        .WithMany()
        .HasForeignKey("provincia");

    }


}
