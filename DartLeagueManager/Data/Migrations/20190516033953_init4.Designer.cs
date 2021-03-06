﻿// <auto-generated />
using DartLeagueManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DartLeagueManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190516033953_init4")]
    partial class init4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DartLeagueManager.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ADAId");

                    b.Property<string>("AssociationId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DartLeagueManager.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DartLeagueManager.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<int>("PlayerId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DartLeagueManager.Models.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("DartLeagueManager.Models.User", b =>
                {
                    b.HasOne("DartLeagueManager.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DartLeagueManager.Models.UserRole", b =>
                {
                    b.HasOne("DartLeagueManager.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DartLeagueManager.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
