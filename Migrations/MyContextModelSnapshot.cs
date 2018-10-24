﻿// <auto-generated />
using forwardDojo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace forwardDojo.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("forwardDojo.Models.Job", b =>
                {
                    b.Property<int>("Job_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("applied");

                    b.Property<string>("company");

                    b.Property<DateTime?>("date");

                    b.Property<string>("description");

                    b.Property<string>("epoch");

                    b.Property<string>("legal");

                    b.Property<string>("logo");

                    b.Property<string>("position");

                    b.Property<string>("slug");

                    b.Property<string>("url");

                    b.HasKey("Job_ID");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("forwardDojo.Models.Joined", b =>
                {
                    b.Property<int>("Joined_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Job_ID");

                    b.Property<int>("User_ID");

                    b.HasKey("Joined_ID");

                    b.HasIndex("Job_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Joineds");
                });

            modelBuilder.Entity("forwardDojo.Models.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PasswordC");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("forwardDojo.Models.Joined", b =>
                {
                    b.HasOne("forwardDojo.Models.Job", "Job")
                        .WithMany("Joineds")
                        .HasForeignKey("Job_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("forwardDojo.Models.User", "User")
                        .WithMany("Joineds")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
