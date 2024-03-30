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
    [Migration("20240330202841_Medicamento")]
    partial class Medicamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cita", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("descripcionCita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCita")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCita");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMascota"));

                    b.Property<int?>("CitaIdCita")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreMascota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.HasKey("IdMascota");

                    b.HasIndex("CitaIdCita");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Padecimiento", b =>
                {
                    b.Property<int>("IdPadecimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPadecimiento"));

                    b.Property<int?>("MascotaIdMascota")
                        .HasColumnType("int");

                    b.Property<string>("descripcionPadecimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPadecimiento");

                    b.HasIndex("MascotaIdMascota");

                    b.ToTable("Padecimiento");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Raza", b =>
                {
                    b.Property<int>("IdRazaMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRazaMascota"));

                    b.Property<int?>("TipoMascotaIdTipoMascota")
                        .HasColumnType("int");

                    b.Property<string>("tipoMascota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRazaMascota");

                    b.HasIndex("TipoMascotaIdTipoMascota");

                    b.ToTable("RazaMascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.TipoMascota", b =>
                {
                    b.Property<int>("IdTipoMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoMascota"));

                    b.Property<int?>("MascotaIdMascota")
                        .HasColumnType("int");

                    b.Property<string>("tipoMascota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoMascota");

                    b.HasIndex("MascotaIdMascota");

                    b.ToTable("TipoMascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("contrasenna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ultimaConexion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Vacuna", b =>
                {
                    b.Property<int>("IdVacuna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVacuna"));

                    b.Property<int?>("MascotaIdMascota")
                        .HasColumnType("int");

                    b.Property<string>("descripcionVacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaVacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipoVacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVacuna");

                    b.HasIndex("MascotaIdMascota");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cita", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Usuario", "Usuario")
                        .WithMany("Citas")
                        .HasForeignKey("UsuarioIdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Mascota", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Cita", "Cita")
                        .WithMany("Mascotas")
                        .HasForeignKey("CitaIdCita");

                    b.Navigation("Cita");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Padecimiento", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Mascota", "Mascota")
                        .WithMany("Padecimientos")
                        .HasForeignKey("MascotaIdMascota");

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Raza", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.TipoMascota", "TipoMascota")
                        .WithMany("Razas")
                        .HasForeignKey("TipoMascotaIdTipoMascota");

                    b.Navigation("TipoMascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.TipoMascota", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Mascota", "Mascota")
                        .WithMany("Tipos")
                        .HasForeignKey("MascotaIdMascota");

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Vacuna", b =>
                {
                    b.HasOne("Sistema_Veterinario.DAL.Mascota", "Mascota")
                        .WithMany("Vacunas")
                        .HasForeignKey("MascotaIdMascota");

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Cita", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Mascota", b =>
                {
                    b.Navigation("Padecimientos");

                    b.Navigation("Tipos");

                    b.Navigation("Vacunas");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.TipoMascota", b =>
                {
                    b.Navigation("Razas");
                });

            modelBuilder.Entity("Sistema_Veterinario.DAL.Usuario", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
