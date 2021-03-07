﻿// <auto-generated />
using System;
using Anneleen_UsersWebAPIAdvanced2.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Anneleen_UsersWebAPIAdvanced2.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20210307141826_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.House", b =>
                {
                    b.Property<int>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("HouseId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("HouseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.HasIndex("HouseId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PetType")
                        .HasColumnType("INTEGER");

                    b.HasKey("PetId");

                    b.HasIndex("PersonId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.Person", b =>
                {
                    b.HasOne("Anneleen_UsersWebAPIAdvanced2.Models.House", "House")
                        .WithMany("Residents")
                        .HasForeignKey("HouseId");

                    b.Navigation("House");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.Pet", b =>
                {
                    b.HasOne("Anneleen_UsersWebAPIAdvanced2.Models.Person", "PetOwner")
                        .WithMany("Pets")
                        .HasForeignKey("PersonId");

                    b.Navigation("PetOwner");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.House", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("Anneleen_UsersWebAPIAdvanced2.Models.Person", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
