﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend2.Data;

namespace backend2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190731133400_iniit")]
    partial class iniit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend2.Models.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("757a6811-0462-49c2-beed-1a5b562ca5f5"),
                            City = "Ghent",
                            Email = "ghent@dundermifflin.com",
                            Latitude = 51.043475999999998,
                            Longitude = 3.7091379999999998,
                            Name = "Dunder Mifflin Ghent"
                        },
                        new
                        {
                            Id = new Guid("5924c7d9-1289-4103-90ac-29cf1df64ce6"),
                            City = "Kortrijk",
                            Email = "kortrijk@dundermifflin.com",
                            Latitude = 50.822955999999998,
                            Longitude = 3.2509619999999999,
                            Name = "Dunder Mifflin Kortrijk"
                        },
                        new
                        {
                            Id = new Guid("af645f49-f884-4eb2-8eed-012e91865458"),
                            City = "Harelbeke",
                            Email = "harelbeke@dundermifflin.com",
                            Latitude = 50.855365999999997,
                            Longitude = 3.3125529999999999,
                            Name = "Dunder Mifflin Harelbeke"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
