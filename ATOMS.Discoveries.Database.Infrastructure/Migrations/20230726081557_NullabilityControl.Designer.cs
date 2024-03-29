﻿// <auto-generated />
using System;
using Atoms.Discoveries.Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Atoms.Discoveries.Database.Infrastructure.Migrations
{
    [DbContext(typeof(DiscoveriesContext))]
    [Migration("20230726081557_NullabilityControl")]
    partial class NullabilityControl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("DiscoverySequence");

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Discovery", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasDefaultValueSql("NEXT VALUE FOR [DiscoverySequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<decimal>("Id"));

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DiscovererId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("DiscoveryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Galaxy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Euclid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("PC");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiscovererId");

                    b.ToTable("Discoveries");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Image", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"));

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscoveryId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("DiscoveryId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.User", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("Id"));

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            NickName = "Maverick von Fritzwilliams"
                        },
                        new
                        {
                            Id = 2m,
                            NickName = "Dragon Kreig"
                        },
                        new
                        {
                            Id = 3m,
                            NickName = "Nut"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.SolarSystem", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.Discovery");

                    b.Property<string>("DominantLifeform")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Abadoned");

                    b.Property<string>("Economy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("None");

                    b.ToTable("SolarSystems");

                    b.HasData(
                        new
                        {
                            Id = 1m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "SolarSystem",
                            Galaxy = "Euclid",
                            Name = "Felucia",
                            Version = "Endurance",
                            DominantLifeform = "Abadoned",
                            Economy = "None"
                        },
                        new
                        {
                            Id = 2m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 2m,
                            DiscoveryType = "SolarSystem",
                            Galaxy = "Euclid",
                            Name = "Kairn",
                            Version = "Endurance",
                            DominantLifeform = "Korvax",
                            Economy = "Tier2"
                        },
                        new
                        {
                            Id = 3m,
                            Coordinates = "0EF6:00FB:0EE5:0025",
                            DiscovererId = 3m,
                            DiscoveryType = "SolarSystem",
                            Galaxy = "Hilbert",
                            Name = "Mepacket",
                            Version = "Endurance",
                            DominantLifeform = "Gek",
                            Economy = "Tier1"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.SystemDiscovery", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.Discovery");

                    b.Property<decimal?>("SolarSystemId")
                        .HasColumnType("decimal(20,0)");

                    b.HasIndex("SolarSystemId");

                    b.ToTable("SystemDiscoveries");

                    b.HasData(
                        new
                        {
                            Id = 18m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 3m,
                            DiscoveryType = "Cosmic structure",
                            Galaxy = "Euclid",
                            Name = "Atlas Messenger",
                            Version = "Endurance",
                            SolarSystemId = 1m
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Freighter", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.SystemDiscovery");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Slots")
                        .HasColumnType("smallint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Freighters");

                    b.HasData(
                        new
                        {
                            Id = 14m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 1m,
                            DiscoveryType = "Freighter",
                            Galaxy = "Euclid",
                            Name = "MS-9 Yanagata",
                            SolarSystemId = 2m,
                            Colors = "Black, Yellow",
                            Slots = (short)40,
                            Type = "Resurgent"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Frigate", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.SystemDiscovery");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Frigates");

                    b.HasData(
                        new
                        {
                            Id = 15m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 3m,
                            DiscoveryType = "Frigate",
                            Galaxy = "Euclid",
                            Name = "Makojim's Omen",
                            SolarSystemId = 1m,
                            Colors = "Red, Black, White",
                            Type = "Combat"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Planet", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.SystemDiscovery");

                    b.Property<string>("Biome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrassColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SentinelsActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkyColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaterColor")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 4m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Planet",
                            Galaxy = "Euclid",
                            Name = "Heff I",
                            Version = "Endurance",
                            SolarSystemId = 1m,
                            Biome = "Temperate",
                            Resources = "Frost crystal, Emeril, Dioxite, Silver",
                            SentinelsActivity = "None"
                        },
                        new
                        {
                            Id = 5m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Planet",
                            Galaxy = "Euclid",
                            Name = "Gefiant IV",
                            Version = "Endurance",
                            SolarSystemId = 1m,
                            Biome = "Icebound",
                            Resources = "Star bulb, Emeril, Parafinium, Magnetized Ferrite",
                            SentinelsActivity = "Aggressive"
                        },
                        new
                        {
                            Id = 6m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Planet",
                            Galaxy = "Euclid",
                            Name = "Ommones Gamma III",
                            Version = "Endurance",
                            SolarSystemId = 1m,
                            Biome = "Arctic",
                            Resources = "Frost crystal, Emeril, Dioxite, Silver",
                            SentinelsActivity = "None"
                        },
                        new
                        {
                            Id = 7m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 2m,
                            DiscoveryType = "Planet",
                            Galaxy = "Euclid",
                            Name = "Aydar II",
                            Version = "Interceptor",
                            SolarSystemId = 2m,
                            Biome = "Vapour",
                            Resources = "Sodium, Parafinium, Copper",
                            SentinelsActivity = "Aggressive"
                        },
                        new
                        {
                            Id = 8m,
                            Coordinates = "0EF6:00FB:0EE5:0025",
                            DiscovererId = 2m,
                            DiscoveryType = "Planet",
                            Galaxy = "Hilbert",
                            Name = "Adninkin Beta",
                            Version = "Singularity",
                            SolarSystemId = 3m,
                            Biome = "Viridescent",
                            Resources = "Star bulb, Copper, Parafinium, Salt",
                            SentinelsActivity = "High"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.PlanetDiscovery", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.SystemDiscovery");

                    b.Property<decimal?>("PlanetId")
                        .HasColumnType("decimal(20,0)");

                    b.HasIndex("PlanetId");

                    b.ToTable("PlanetDiscoveries");

                    b.HasData(
                        new
                        {
                            Id = 11m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Base",
                            Galaxy = "Euclid",
                            Name = "Felucia",
                            Version = "Endurance",
                            PlanetId = 4m
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Fauna", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.PlanetDiscovery");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Fauna");

                    b.HasData(
                        new
                        {
                            Id = 12m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Fauna",
                            Galaxy = "Euclid",
                            Name = "C. Livercoyllera",
                            PlanetId = 4m,
                            Height = 1.2,
                            Species = "Robot"
                        },
                        new
                        {
                            Id = 13m,
                            Coordinates = "0FE8:00B0:0C61:0089",
                            DiscovererId = 1m,
                            DiscoveryType = "Fauna",
                            Galaxy = "Euclid",
                            Name = "C. Potasamensium",
                            PlanetId = 4m,
                            Height = 1.7,
                            Species = "Robot"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.MultiTool", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.PlanetDiscovery");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("MultiTools");

                    b.HasData(
                        new
                        {
                            Id = 16m,
                            Coordinates = "0EF6:00FB:0EE5:0025",
                            DiscovererId = 3m,
                            DiscoveryType = "Ship",
                            Galaxy = "Hilbert",
                            Name = "Messenger of the Anomaly G-2-92T",
                            SolarSystemId = 3m,
                            Class = "A",
                            Size = "Rifle",
                            Type = "Experimental"
                        },
                        new
                        {
                            Id = 17m,
                            Coordinates = "0EF6:00FB:0EE5:0025",
                            DiscovererId = 3m,
                            DiscoveryType = "Ship",
                            Galaxy = "Hilbert",
                            Name = "Touch of Matter",
                            SolarSystemId = 3m,
                            PlanetId = 8m,
                            Class = "B",
                            Size = "Rifle",
                            Type = "Alien"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Ship", b =>
                {
                    b.HasBaseType("Atoms.Discoveries.Database.Domain.PlanetDiscovery");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Slots")
                        .HasColumnType("smallint");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Ships");

                    b.HasData(
                        new
                        {
                            Id = 9m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 3m,
                            DiscoveryType = "Ship",
                            Galaxy = "Euclid",
                            Name = "Flameborn",
                            Version = "Singularity",
                            SolarSystemId = 2m,
                            Class = "S",
                            Colors = "White, Black, Red",
                            Slots = (short)25,
                            Type = "Interceptor"
                        },
                        new
                        {
                            Id = 10m,
                            Coordinates = "04DF:00CA:0551:0197",
                            DiscovererId = 3m,
                            DiscoveryType = "Ship",
                            Galaxy = "Euclid",
                            Name = "Katori de Loucura",
                            Version = "Singularity",
                            SolarSystemId = 2m,
                            PlanetId = 7m,
                            Class = "A",
                            Colors = "White, Black, Orange",
                            Slots = (short)20,
                            Type = "Exotic"
                        });
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Discovery", b =>
                {
                    b.HasOne("Atoms.Discoveries.Database.Domain.User", "Discoverer")
                        .WithMany("Discoveries")
                        .HasForeignKey("DiscovererId");

                    b.Navigation("Discoverer");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Image", b =>
                {
                    b.HasOne("Atoms.Discoveries.Database.Domain.Discovery", "Discovery")
                        .WithMany("Images")
                        .HasForeignKey("DiscoveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discovery");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.SystemDiscovery", b =>
                {
                    b.HasOne("Atoms.Discoveries.Database.Domain.SolarSystem", "SolarSystem")
                        .WithMany("Discoveries")
                        .HasForeignKey("SolarSystemId");

                    b.Navigation("SolarSystem");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.PlanetDiscovery", b =>
                {
                    b.HasOne("Atoms.Discoveries.Database.Domain.Planet", "Planet")
                        .WithMany("Discoveries")
                        .HasForeignKey("PlanetId");

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Discovery", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.User", b =>
                {
                    b.Navigation("Discoveries");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.SolarSystem", b =>
                {
                    b.Navigation("Discoveries");
                });

            modelBuilder.Entity("Atoms.Discoveries.Database.Domain.Planet", b =>
                {
                    b.Navigation("Discoveries");
                });
#pragma warning restore 612, 618
        }
    }
}
