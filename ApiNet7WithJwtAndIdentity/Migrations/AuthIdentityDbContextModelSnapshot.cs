﻿// <auto-generated />
using System;
using ApiNet7WithJwtAndIdentity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiNet7WithJwtAndIdentity.Migrations
{
    [DbContext(typeof(AuthIdentityDbContext))]
    partial class AuthIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Asesores", b =>
                {
                    b.Property<string>("IdAsesor")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdAsesor");

                    b.ToTable("Asesores");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Corraloneros", b =>
                {
                    b.Property<string>("IdCorralonero")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdCorralonero");

                    b.ToTable("Corraloneros");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Corralones", b =>
                {
                    b.Property<int>("IdCorralon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCorralon"));

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DiasActivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("IdCorralonero")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdRegion")
                        .HasColumnType("int");

                    b.Property<int>("IdUbicacion")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IdCorralon");

                    b.HasIndex("IdCorralonero")
                        .IsUnique();

                    b.HasIndex("IdRegion")
                        .IsUnique();

                    b.HasIndex("IdUbicacion")
                        .IsUnique();

                    b.ToTable("Corralones");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Regiones", b =>
                {
                    b.Property<int>("IdRegion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegion"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdRegion");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Siniestros", b =>
                {
                    b.Property<int>("IdSiniestro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSiniestro"));

                    b.Property<string>("Detalles")
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Folio")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("IdAsesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdUbicacion")
                        .HasColumnType("int");

                    b.HasKey("IdSiniestro");

                    b.HasIndex("IdAsesor")
                        .IsUnique();

                    b.HasIndex("IdUbicacion")
                        .IsUnique();

                    b.ToTable("Siniestros");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.TipoGruas", b =>
                {
                    b.Property<int>("IdTipoGruas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoGruas"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdTipoGruas");

                    b.ToTable("TipoGruas");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Ubicaciones", b =>
                {
                    b.Property<int>("IdUbicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUbicacion"));

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cp")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NumeroExterior")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroInterior")
                        .HasColumnType("int");

                    b.HasKey("IdUbicacion");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Vehiculos", b =>
                {
                    b.Property<int>("IdVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVehiculo"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdVehiculo");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GestionPracticasProfesionalesUtp.Models.Usuarios", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("Usuarios");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Asesores", b =>
                {
                    b.HasOne("GestionPracticasProfesionalesUtp.Models.Usuarios", "Usuario")
                        .WithOne("Asesor")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Asesores", "IdAsesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Corraloneros", b =>
                {
                    b.HasOne("GestionPracticasProfesionalesUtp.Models.Usuarios", "Usuario")
                        .WithOne("Corralonero")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Corraloneros", "IdCorralonero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Corralones", b =>
                {
                    b.HasOne("ApiNet7WithJwtAndIdentity.Models.Corraloneros", "Corralonero")
                        .WithOne("Corralon")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Corralones", "IdCorralonero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiNet7WithJwtAndIdentity.Models.Regiones", "Region")
                        .WithOne("Corralon")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Corralones", "IdRegion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiNet7WithJwtAndIdentity.Models.Ubicaciones", "Ubicacion")
                        .WithOne("Corralon")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Corralones", "IdUbicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Corralonero");

                    b.Navigation("Region");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Siniestros", b =>
                {
                    b.HasOne("ApiNet7WithJwtAndIdentity.Models.Asesores", "Asesor")
                        .WithOne("Siniestro")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Siniestros", "IdAsesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiNet7WithJwtAndIdentity.Models.Ubicaciones", "Ubicacion")
                        .WithOne("Siniestro")
                        .HasForeignKey("ApiNet7WithJwtAndIdentity.Models.Siniestros", "IdUbicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asesor");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Asesores", b =>
                {
                    b.Navigation("Siniestro")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Corraloneros", b =>
                {
                    b.Navigation("Corralon")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Regiones", b =>
                {
                    b.Navigation("Corralon")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiNet7WithJwtAndIdentity.Models.Ubicaciones", b =>
                {
                    b.Navigation("Corralon")
                        .IsRequired();

                    b.Navigation("Siniestro")
                        .IsRequired();
                });

            modelBuilder.Entity("GestionPracticasProfesionalesUtp.Models.Usuarios", b =>
                {
                    b.Navigation("Asesor")
                        .IsRequired();

                    b.Navigation("Corralonero")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
