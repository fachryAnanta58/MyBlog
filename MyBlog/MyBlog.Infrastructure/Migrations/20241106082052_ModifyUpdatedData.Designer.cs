﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlog.Infrastructure;

#nullable disable

namespace MyBlog.Infrastructure.Migrations
{
    [DbContext(typeof(MyBlogDbContext))]
    [Migration("20241106082052_ModifyUpdatedData")]
    partial class ModifyUpdatedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("MyBlog.Domain.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Experiences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Company = "My Company",
                            Created = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Developing software",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Location = "Jakarta, Indonesia",
                            ProfileId = -1,
                            StartDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tags = "[\"C#\",\"ASP.NET Core\",\"Entity Framework Core\"]",
                            Title = "Software Engineer",
                            Updated = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePreview")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Content = "This is my first seed post",
                            Created = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            IsActive = true,
                            ProfileId = -1,
                            Subtitle = "This is my first post",
                            Title = "My First Post",
                            Updated = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = -2,
                            Content = "This is my second seed post",
                            Created = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            IsActive = true,
                            ProfileId = -1,
                            Subtitle = "This is my second post",
                            Title = "My Second Post",
                            Updated = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Bio = "Software Engineer",
                            Created = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "fachry.ananta18@gmail.com",
                            IsActive = true,
                            Name = "Fachry Ananta",
                            PhoneNumber = "081234567890",
                            ProfilePicture = "profile.jpg",
                            Skills = "[\"C#\",\"ASP.NET Core\",\"Entity Framework Core\"]",
                            Updated = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("DemoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GitHubUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Screenshots")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Technologies")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Projects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Created = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            DemoUrl = "https://demo.com",
                            Description = "Developing a project",
                            Features = "[\"Feature 1\",\"Feature 2\",\"Feature 3\"]",
                            GitHubUrl = "https://github.com",
                            ImageUrl = "project.jpg",
                            IsActive = true,
                            Name = "My Project",
                            ProfileId = -1,
                            Screenshots = "[\"screenshot1.jpg\",\"screenshot2.jpg\",\"screenshot3.jpg\"]",
                            Tags = "[\"C#\",\"ASP.NET Core\",\"Entity Framework Core\"]",
                            Technologies = "[\"C#\",\"ASP.NET Core\",\"Entity Framework Core\"]",
                            Updated = new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Experience", b =>
                {
                    b.HasOne("MyBlog.Domain.Models.Profile", "Profile")
                        .WithMany("Experiences")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Post", b =>
                {
                    b.HasOne("MyBlog.Domain.Models.Profile", "Profile")
                        .WithMany("Posts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Project", b =>
                {
                    b.HasOne("MyBlog.Domain.Models.Profile", "Profile")
                        .WithMany("Projects")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("MyBlog.Domain.Models.Profile", b =>
                {
                    b.Navigation("Experiences");

                    b.Navigation("Posts");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
