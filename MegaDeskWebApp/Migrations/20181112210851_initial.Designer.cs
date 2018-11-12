﻿// <auto-generated />
using System;
using MegaDeskWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWebApp.Migrations
{
    [DbContext(typeof(MegaDeskWebAppContext))]
    [Migration("20181112210851_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWebApp.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustName")
                        .IsRequired();

                    b.Property<int>("DeskDepth");

                    b.Property<int>("DeskDrawers");

                    b.Property<DateTime>("DeskQuoteDate");

                    b.Property<int>("DeskQuoteTotal");

                    b.Property<int>("DeskWidth");

                    b.Property<int>("RushDays");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
