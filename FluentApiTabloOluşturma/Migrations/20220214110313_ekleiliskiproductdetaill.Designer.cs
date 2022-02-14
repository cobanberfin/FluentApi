﻿// <auto-generated />
using FluentApiTabloOluşturma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiTabloOluşturma.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220214110313_ekleiliskiproductdetaill")]
    partial class ekleiliskiproductdetaill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Firma", b =>
                {
                    b.Property<int>("Anahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNumarası")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirmaUnvan");

                    b.HasKey("Anahtar");

                    b.ToTable("Tbl_Firma");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Personel", b =>
                {
                    b.Property<int>("Anahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Soyad");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelefonNumarası");

                    b.Property<int>("firID")
                        .HasColumnType("int");

                    b.Property<string>("İsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ad");

                    b.HasKey("Anahtar");

                    b.HasIndex("firID");

                    b.ToTable("Tbl_Personel");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ürünİsmi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.ProductDEtails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Renk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prtID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("prtID")
                        .IsUnique();

                    b.ToTable("ProductDEtails");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Suplier", b =>
                {
                    b.Property<int>("SuplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("İsim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şehir")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuplierID");

                    b.ToTable("Supliers");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.SuplierProduct", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("SuplierID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "SuplierID");

                    b.HasIndex("SuplierID");

                    b.ToTable("suplierProducts");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Personel", b =>
                {
                    b.HasOne("FluentApiTabloOluşturma.Models.Firma", "Firma")
                        .WithMany("personeller")
                        .HasForeignKey("firID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.ProductDEtails", b =>
                {
                    b.HasOne("FluentApiTabloOluşturma.Models.Product", "Product")
                        .WithOne("ProductDEtails")
                        .HasForeignKey("FluentApiTabloOluşturma.Models.ProductDEtails", "prtID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.SuplierProduct", b =>
                {
                    b.HasOne("FluentApiTabloOluşturma.Models.Product", "Product")
                        .WithMany("SuplierProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentApiTabloOluşturma.Models.Suplier", "Suplier")
                        .WithMany("SuplierProducts")
                        .HasForeignKey("SuplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Suplier");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Firma", b =>
                {
                    b.Navigation("personeller");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Product", b =>
                {
                    b.Navigation("ProductDEtails");

                    b.Navigation("SuplierProducts");
                });

            modelBuilder.Entity("FluentApiTabloOluşturma.Models.Suplier", b =>
                {
                    b.Navigation("SuplierProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
