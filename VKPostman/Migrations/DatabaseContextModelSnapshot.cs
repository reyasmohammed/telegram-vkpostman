﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using VKPostman.DAL;

namespace VKPostman.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("VKPostman.Models.PublicPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("LastPostId");

                    b.Property<string>("Name");

                    b.Property<long>("PageVkId");

                    b.Property<string>("ScreenName");

                    b.HasKey("Id");

                    b.ToTable("PublicPages");
                });

            modelBuilder.Entity("VKPostman.Models.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ChatId");

                    b.HasKey("Id");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("VKPostman.Models.Subscription", b =>
                {
                    b.Property<int>("SubscriberId");

                    b.Property<int>("PublicPageId");

                    b.HasKey("SubscriberId", "PublicPageId");

                    b.HasIndex("PublicPageId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("VKPostman.Models.Subscription", b =>
                {
                    b.HasOne("VKPostman.Models.PublicPage", "PublicPage")
                        .WithMany("Subscriptions")
                        .HasForeignKey("PublicPageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VKPostman.Models.Subscriber", "Subscriber")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
