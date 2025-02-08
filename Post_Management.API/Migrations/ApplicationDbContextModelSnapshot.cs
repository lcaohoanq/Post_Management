﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Post_Management.API.Data;

#nullable disable

namespace Post_Management.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlogPostCategory", b =>
                {
                    b.Property<Guid>("BlogPostsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uuid");

                    b.HasKey("BlogPostsId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BlogPostCategory");
                });

            modelBuilder.Entity("Post_Management.API.Models.Domains.BlogImage", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("URl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("BlogImages");
                });

            modelBuilder.Entity("Post_Management.API.Models.Domains.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "author");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "content");

                    b.Property<string>("FeaturedImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "featured_image_url");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "publish_date");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "short_description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "url_handle");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("Post_Management.API.Models.Domains.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "url_handle");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BlogPostCategory", b =>
                {
                    b.HasOne("Post_Management.API.Models.Domains.BlogPost", null)
                        .WithMany()
                        .HasForeignKey("BlogPostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Post_Management.API.Models.Domains.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
