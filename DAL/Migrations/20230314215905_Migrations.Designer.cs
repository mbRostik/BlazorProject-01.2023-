﻿// <auto-generated />
using System;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CSContext))]
    [Migration("20230314215905_Migrations")]
    partial class Migrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("Price")
                        .HasMaxLength(10)
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Coins", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BNB",
                            Price = 200f
                        },
                        new
                        {
                            Id = 2,
                            Name = "BTC",
                            Price = 60000f
                        },
                        new
                        {
                            Id = 3,
                            Name = "SCP",
                            Price = 500f
                        });
                });

            modelBuilder.Entity("DAL.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId1")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PostId");

                    b.HasIndex("PostId1");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Follower", b =>
                {
                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("IdleId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("FollowerId", "IdleId");

                    b.HasIndex("IdleId");

                    b.ToTable("Followers", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PostId");

                    b.HasIndex("PostId1");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserId", "PostId")
                        .IsUnique();

                    b.ToTable("Likes", (string)null);
                });

            modelBuilder.Entity("DAL.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Media")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("News", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Media = "dcw",
                            Text = "ghbrfvdncjkmfenhvdjcmkjifnhgvfdcjmkievjgnbhfjndckmjdjfvngb"
                        },
                        new
                        {
                            Id = 2,
                            Media = "dcw",
                            Text = "bgrvfevegrbh"
                        },
                        new
                        {
                            Id = 3,
                            Media = "BabaVanga",
                            Text = "BTC 60000!"
                        });
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 3, 14, 23, 59, 5, 27, DateTimeKind.Local).AddTicks(4960),
                            Photo = "",
                            Text = "Hahahhahahaha ahkhvfbdcjsnknfdvgbhvjdn",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 3, 14, 23, 59, 5, 27, DateTimeKind.Local).AddTicks(5016),
                            Photo = "",
                            Text = "brgfvdcvgrhbt ahkhvfbdcjsnknfdvgbhvjdn",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 3, 14, 23, 59, 5, 27, DateTimeKind.Local).AddTicks(5019),
                            Photo = "",
                            Text = "refrwreftg rsvfead",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "rost.daskalyuk@gmail.com",
                            Password = "qwerty123",
                            RoleId = 1,
                            UserName = "Rostik"
                        },
                        new
                        {
                            Id = 2,
                            Email = "valik.romanyuk2004@gmail.com",
                            Password = "qwerty123",
                            RoleId = 1,
                            UserName = "Valik"
                        },
                        new
                        {
                            Id = 3,
                            Email = "valentanys@gmail.com",
                            Password = "qwerty123",
                            RoleId = 1,
                            UserName = "ValentAnys"
                        });
                });

            modelBuilder.Entity("DAL.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoinId")
                        .HasColumnType("int");

                    b.Property<float>("Count")
                        .HasMaxLength(200000)
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoinId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId", "CoinId")
                        .IsUnique();

                    b.ToTable("Wallets", null, t =>
                        {
                            t.HasCheckConstraint("Count", "Count > 0");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoinId = 1,
                            Count = 1f,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CoinId = 2,
                            Count = 1f,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CoinId = 3,
                            Count = 1f,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("DAL.Models.Comment", b =>
                {
                    b.HasOne("DAL.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Models.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId1");

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", null)
                        .WithMany("Comments")
                        .HasForeignKey("UserId1");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Follower", b =>
                {
                    b.HasOne("DAL.Models.User", "follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "idle")
                        .WithMany()
                        .HasForeignKey("IdleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("follower");

                    b.Navigation("idle");
                });

            modelBuilder.Entity("DAL.Models.Like", b =>
                {
                    b.HasOne("DAL.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Models.Post", null)
                        .WithMany("Likes")
                        .HasForeignKey("PostId1");

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", null)
                        .WithMany("Likes")
                        .HasForeignKey("UserId1");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.HasOne("DAL.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DAL.Models.Wallet", b =>
                {
                    b.HasOne("DAL.Models.Coin", "coin")
                        .WithMany("Wallets")
                        .HasForeignKey("CoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "user")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("coin");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DAL.Models.Coin", b =>
                {
                    b.Navigation("Wallets");
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("DAL.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");

                    b.Navigation("Posts");

                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
