﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpScape.Api.Data;

#nullable disable

namespace SharpScape.Api.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("SharpScape.Api.Models.ForumCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ForumCategoryAuthor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumCategoryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ForumCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ForumCategoryAuthor = "Category Author 1 ",
                            ForumCategoryDescription = "Category Description 1",
                            ForumCategoryName = "Category Name 1"
                        },
                        new
                        {
                            Id = 2,
                            ForumCategoryAuthor = "Category Author 2",
                            ForumCategoryDescription = "Category Description 2",
                            ForumCategoryName = "Category Name 2"
                        },
                        new
                        {
                            Id = 3,
                            ForumCategoryAuthor = "Category Author 3",
                            ForumCategoryDescription = "Category Description 3",
                            ForumCategoryName = "Category Name 3"
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ForumAuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ForumPostBody")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumPostTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ForumThreadId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ForumPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ForumAuthorId = 1,
                            ForumPostBody = "post1  Body",
                            ForumPostTitle = "post1 title",
                            ForumThreadId = 2
                        },
                        new
                        {
                            Id = 2,
                            ForumAuthorId = 1,
                            ForumPostBody = "post2  Body",
                            ForumPostTitle = "post2 title",
                            ForumThreadId = 3
                        },
                        new
                        {
                            Id = 3,
                            ForumAuthorId = 1,
                            ForumPostBody = "post3  Body",
                            ForumPostTitle = "post3 title",
                            ForumThreadId = 3
                        },
                        new
                        {
                            Id = 4,
                            ForumAuthorId = 2,
                            ForumPostBody = "post4  Body",
                            ForumPostTitle = "post4 title",
                            ForumThreadId = 3
                        },
                        new
                        {
                            Id = 5,
                            ForumAuthorId = 2,
                            ForumPostBody = "post5  Body",
                            ForumPostTitle = "post5 title",
                            ForumThreadId = 4
                        },
                        new
                        {
                            Id = 6,
                            ForumAuthorId = 3,
                            ForumPostBody = "post6  Body",
                            ForumPostTitle = "post6 title",
                            ForumThreadId = 5
                        },
                        new
                        {
                            Id = 7,
                            ForumAuthorId = 3,
                            ForumPostBody = "post7  Body",
                            ForumPostTitle = "post7 title",
                            ForumThreadId = 5
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumThread", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Replies")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Views")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("ForumThreads");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Body = " body 1",
                            CategoryId = 2,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(52),
                            Replies = 0,
                            Title = "tr1",
                            UserId = 2,
                            Views = 0,
                            Votes = 0
                        },
                        new
                        {
                            Id = 4,
                            Body = " body 1",
                            CategoryId = 2,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(64),
                            Replies = 0,
                            Title = "tr1",
                            UserId = 1,
                            Views = 0,
                            Votes = 0
                        },
                        new
                        {
                            Id = 3,
                            Body = " body 1",
                            CategoryId = 1,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(70),
                            Replies = 0,
                            Title = "tr1",
                            UserId = 1,
                            Views = 0,
                            Votes = 0
                        },
                        new
                        {
                            Id = 2,
                            Body = " body 1",
                            CategoryId = 3,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(76),
                            Replies = 0,
                            Title = "tr1",
                            UserId = 3,
                            Views = 0,
                            Votes = 0
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9795),
                            Email = "ss1@ss.ss",
                            PasswordHash = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            PasswordSalt = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = "User",
                            Username = "ss1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9802),
                            Email = "ss2@ss.ss",
                            PasswordHash = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            PasswordSalt = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = "User",
                            Username = "ss2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9808),
                            Email = "ss3@ss.ss",
                            PasswordHash = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            PasswordSalt = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Role = "User",
                            Username = "ss3"
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumThread", b =>
                {
                    b.HasOne("SharpScape.Api.Models.ForumCategory", "ForumCategory")
                        .WithMany("Threads")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpScape.Api.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("ForumCategory");
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumCategory", b =>
                {
                    b.Navigation("Threads");
                });
#pragma warning restore 612, 618
        }
    }
}
