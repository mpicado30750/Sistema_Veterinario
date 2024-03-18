﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Veterinario.DAL;

#nullable disable

namespace Sistema_Veterinario.DAL.Migrations
{
    [DbContext(typeof(Sistema_VeterinarioDbContext))]
    [Migration("20240318024717_contactoveterinario")]
    partial class contactoveterinario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cita", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitaId"));

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.HasKey("CitaId");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Contacto", b =>
                {
                    b.Property<int>("ContactoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactoId"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("ContactoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Diagnostico", b =>
                {
                    b.Property<int>("DiagnosticoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosticoId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreDiagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnosticoId");

                    b.ToTable("Diagnostico");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MascotaId"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MascotaId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Medicamento", b =>
                {
                    b.Property<int>("MedicamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicamentoId"));

                    b.Property<string>("NombreMedicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicamentoId");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Padecimiento", b =>
                {
                    b.Property<int>("PadecimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PadecimientoId"));

                    b.Property<string>("NombrePadecimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PadecimientoId");

                    b.ToTable("Padecimiento");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Vacuna", b =>
                {
                    b.Property<int>("VacunaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacunaId"));

                    b.Property<DateTime>("FechaAplicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacunaId");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Veterinario", b =>
                {
                    b.Property<int>("VeterinarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VeterinarioId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeterinarioId");

                    b.ToTable("Veterinario");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Contacto", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Cliente", "Cliente")
                        .WithMany("Contactos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Sistema_Veterinario.DAL.Veterinario", "Veterinario")
                        .WithMany("Contactos")
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Cliente");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cliente", b =>
                {
                    b.Navigation("Contactos");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Veterinario", b =>
                {
                    b.Navigation("Contactos");
                });
#pragma warning restore 612, 618
        }
    }
}
