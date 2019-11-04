﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value 101"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value 201"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value 301"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Value 401"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Value 501"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Value 601"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Value 701"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
