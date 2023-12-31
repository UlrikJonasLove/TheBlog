﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231017155853_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.Posts.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 1",
                            Image = "image1.jpg",
                            LastEdited = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 2",
                            Image = "image2.jpg",
                            LastEdited = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 3",
                            Image = "image3.jpg",
                            LastEdited = new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 3"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 4",
                            Image = "image4.jpg",
                            LastEdited = new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 4"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 5",
                            Image = "image5.jpg",
                            LastEdited = new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 5"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 6",
                            Image = "image6.jpg",
                            LastEdited = new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 6"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 7",
                            Image = "image7.jpg",
                            LastEdited = new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 7"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 8",
                            Image = "image8.jpg",
                            LastEdited = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 8"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 9",
                            Image = "image9.jpg",
                            LastEdited = new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 9"
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 10",
                            Image = "image10.jpg",
                            LastEdited = new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 10"
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 11",
                            Image = "image11.jpg",
                            LastEdited = new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 11"
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 12",
                            Image = "image12.jpg",
                            LastEdited = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 12"
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 13",
                            Image = "image13.jpg",
                            LastEdited = new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 13"
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 14",
                            Image = "image14.jpg",
                            LastEdited = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 14"
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Beskrivning för post 15",
                            Image = "image15.jpg",
                            LastEdited = new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Post 15"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
