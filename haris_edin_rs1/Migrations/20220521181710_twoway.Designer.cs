﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using haris_edin_rs1.Data;

namespace haris_edin_rs1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220521181710_twoway")]
    partial class twoway
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("haris_edin_rs1.Models.Artikal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ABS")
                        .HasColumnType("bit");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("Brend_id")
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("DetaljanOpis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Godiste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gorivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kategorija_Produkta_id")
                        .HasColumnType("int");

                    b.Property<string>("Kilometraza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Klima")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivArtikla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Plin")
                        .HasColumnType("bit");

                    b.Property<bool>("Registrovan")
                        .HasColumnType("bit");

                    b.Property<string>("SlikaArtikla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stanje_id")
                        .HasColumnType("int");

                    b.Property<int>("korisnik_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Brend_id");

                    b.HasIndex("Kategorija_Produkta_id");

                    b.HasIndex("Stanje_id");

                    b.HasIndex("korisnik_id");

                    b.ToTable("Artikal");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.ArtikalSlika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Artikal_id")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Artikal_id");

                    b.ToTable("ArtikalSlika");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Brend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brend");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.KategorijaProdukta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KategorijaProdukta");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Artikal_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("SadrzajKomentara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("korisnik_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Artikal_id");

                    b.HasIndex("korisnik_id");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Poruke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Posiljaoc_id")
                        .HasColumnType("int");

                    b.Property<int>("Primaoc_id")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Posiljaoc_id");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Stanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stanje");
                });

            modelBuilder.Entity("haris_edin_rs1.ModelsAutentififkacija.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvideniranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("korisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Administrator", b =>
                {
                    b.HasBaseType("haris_edin_rs1.Models.KorisnickiNalog");

                    b.Property<string>("AdministratorIme")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Korisnik", b =>
                {
                    b.HasBaseType("haris_edin_rs1.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grad_id")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KontaktTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaProfila")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Spol_id")
                        .HasColumnType("int");

                    b.Property<bool>("Twoway")
                        .HasColumnType("bit");

                    b.HasIndex("Grad_id");

                    b.HasIndex("Spol_id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Artikal", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.Brend", "brend")
                        .WithMany()
                        .HasForeignKey("Brend_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.KategorijaProdukta", "kategorijaprodukta")
                        .WithMany()
                        .HasForeignKey("Kategorija_Produkta_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.Stanje", "stanje")
                        .WithMany()
                        .HasForeignKey("Stanje_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnik_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brend");

                    b.Navigation("kategorijaprodukta");

                    b.Navigation("korisnik");

                    b.Navigation("stanje");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.ArtikalSlika", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("Artikal_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artikal");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Komentar", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.Artikal", "artikal")
                        .WithMany()
                        .HasForeignKey("Artikal_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnik_id");

                    b.Navigation("artikal");

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Poruke", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("Posiljaoc_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("haris_edin_rs1.ModelsAutentififkacija.AutentifikacijaToken", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("korisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Administrator", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("haris_edin_rs1.Models.Administrator", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("haris_edin_rs1.Models.Korisnik", b =>
                {
                    b.HasOne("haris_edin_rs1.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("Grad_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("haris_edin_rs1.Models.Korisnik", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("haris_edin_rs1.Models.Spol", "spol")
                        .WithMany()
                        .HasForeignKey("Spol_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grad");

                    b.Navigation("spol");
                });
#pragma warning restore 612, 618
        }
    }
}
