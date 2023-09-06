﻿// <auto-generated />
using System;
using GeoShared.Main.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeoShared.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230906015239_updateProvincia")]
    partial class updateProvincia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Main.Models.BiomaModel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("clima")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("name");

                    b.ToTable("Bioma");
                });

            modelBuilder.Entity("Main.Models.ContinenteModel", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BiomaName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<float>("latitude")
                        .HasColumnType("float");

                    b.Property<float>("longitude")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.HasIndex("BiomaName");

                    b.ToTable("Continente");
                });

            modelBuilder.Entity("Main.Models.GovenadorModel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("nacionality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("policy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("provincia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("name");

                    b.ToTable("Govenador");
                });

            modelBuilder.Entity("Main.Models.ImagemModel", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("Main.Models.PresidenteModel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("policy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("name");

                    b.ToTable("Presidente");
                });

            modelBuilder.Entity("Main.Models.ProvinciaModel", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Bioma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Biomasname")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ddd")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("latitude")
                        .HasColumnType("float");

                    b.Property<float>("longitude")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("population")
                        .HasColumnType("int");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("code");

                    b.HasIndex("Biomasname");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Main.Models.QuizModel", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("continente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("orientation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("population")
                        .HasColumnType("int");

                    b.Property<int>("temperature")
                        .HasColumnType("int");

                    b.Property<string>("urlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("validation")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("name");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("Main.Models.ContinenteModel", b =>
                {
                    b.HasOne("Main.Models.BiomaModel", "Bioma")
                        .WithMany("Continentes")
                        .HasForeignKey("BiomaName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bioma");
                });

            modelBuilder.Entity("Main.Models.ProvinciaModel", b =>
                {
                    b.HasOne("Main.Models.BiomaModel", "Biomas")
                        .WithMany()
                        .HasForeignKey("Biomasname");

                    b.Navigation("Biomas");
                });

            modelBuilder.Entity("Main.Models.BiomaModel", b =>
                {
                    b.Navigation("Continentes");
                });
#pragma warning restore 612, 618
        }
    }
}
