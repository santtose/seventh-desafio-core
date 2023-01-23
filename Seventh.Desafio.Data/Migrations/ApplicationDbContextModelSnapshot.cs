﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seventh.Desafio.Data.Context;

namespace Seventh.Desafio.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Seventh.Desafio.Business.Entidades.Servidor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IpPorta")
                        .HasColumnType("int");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDisponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servidores");
                });

            modelBuilder.Entity("Seventh.Desafio.Business.Entidades.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRunning")
                        .HasColumnType("bit");

                    b.Property<Guid>("ServidorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VideoUpload")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ServidorId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Seventh.Desafio.Business.Entidades.Video", b =>
                {
                    b.HasOne("Seventh.Desafio.Business.Entidades.Servidor", "Servidor")
                        .WithMany("Videos")
                        .HasForeignKey("ServidorId")
                        .IsRequired();

                    b.Navigation("Servidor");
                });

            modelBuilder.Entity("Seventh.Desafio.Business.Entidades.Servidor", b =>
                {
                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
