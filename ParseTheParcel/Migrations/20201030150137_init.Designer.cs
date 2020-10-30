﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParseTheParcel.Models;

namespace ParseTheParcel.Migrations
{
    [DbContext(typeof(ParseTheParcelDbContext))]
    [Migration("20201030150137_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParseTheParcel.Models.ParseTheParcelModels.ParseTheParcelRule", b =>
                {
                    b.Property<int>("RuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Breadth")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("RuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("RuleOrder")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("RuleID");

                    b.HasIndex("RuleOrder")
                        .IsUnique();

                    b.ToTable("parseTheParcelRules");

                    b.HasData(
                        new
                        {
                            RuleID = 1,
                            Breadth = 300,
                            Height = 150,
                            Length = 200,
                            Price = 5.0,
                            RuleName = "Small",
                            RuleOrder = 1,
                            Weight = 25000
                        },
                        new
                        {
                            RuleID = 2,
                            Breadth = 400,
                            Height = 200,
                            Length = 300,
                            Price = 7.5,
                            RuleName = "Medium",
                            RuleOrder = 2,
                            Weight = 25000
                        },
                        new
                        {
                            RuleID = 3,
                            Breadth = 600,
                            Height = 250,
                            Length = 400,
                            Price = 8.5,
                            RuleName = "Large",
                            RuleOrder = 3,
                            Weight = 25000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
