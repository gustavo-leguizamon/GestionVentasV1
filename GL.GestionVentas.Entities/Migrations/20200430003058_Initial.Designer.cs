﻿// <auto-generated />
using System;
using GL.GestionVentas.Entities.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GL.GestionVentas.Entities.Migrations
{
    [DbContext(typeof(EntitiesContext))]
    [Migration("20200430003058_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GL.GestionVentas.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellido = "Perez",
                            DNI = "30000001",
                            Direccion = "Calle falsa 123",
                            Nombre = "Roberto",
                            Telefono = "12345678"
                        },
                        new
                        {
                            ClienteId = 2,
                            Apellido = "Fulanito",
                            DNI = "40000001",
                            Direccion = "Av. Mitre 123",
                            Nombre = "Cosme",
                            Telefono = "12345555"
                        },
                        new
                        {
                            ClienteId = 3,
                            Apellido = "Rodriguez",
                            DNI = "50000001",
                            Direccion = "Calchaqui 3000",
                            Nombre = "Patricia",
                            Telefono = "11111111"
                        });
                });

            modelBuilder.Entity("GL.GestionVentas.Entities.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("ProductoId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Codigo = "MOU",
                            Marca = "Noganet",
                            Nombre = "Mouse",
                            Precio = 10m
                        },
                        new
                        {
                            ProductoId = 2,
                            Codigo = "CAM",
                            Nombre = "Camara",
                            Precio = 15m
                        },
                        new
                        {
                            ProductoId = 3,
                            Codigo = "TEC",
                            Marca = "Noganet",
                            Nombre = "Teclado",
                            Precio = 20m
                        },
                        new
                        {
                            ProductoId = 4,
                            Codigo = "MON",
                            Marca = "Samsung",
                            Nombre = "Monitor",
                            Precio = 38m
                        },
                        new
                        {
                            ProductoId = 5,
                            Codigo = "CPU",
                            Marca = "Gigabit",
                            Nombre = "CPU",
                            Precio = 250m
                        });
                });

            modelBuilder.Entity("GL.GestionVentas.Entities.Ventas", b =>
                {
                    b.Property<int>("VentasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("VentasId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            VentasId = 1,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 4, 29, 21, 30, 57, 272, DateTimeKind.Local).AddTicks(250),
                            ProductoId = 1
                        },
                        new
                        {
                            VentasId = 2,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 4, 29, 21, 30, 57, 273, DateTimeKind.Local).AddTicks(7009),
                            ProductoId = 2
                        });
                });

            modelBuilder.Entity("GL.GestionVentas.Entities.Ventas", b =>
                {
                    b.HasOne("GL.GestionVentas.Entities.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GL.GestionVentas.Entities.Producto", "Producto")
                        .WithMany("Ventas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
