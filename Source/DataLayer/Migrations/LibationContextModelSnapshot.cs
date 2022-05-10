﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(LibationContext))]
    partial class LibationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("DataLayer.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AudibleProductId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContentType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DatePublished")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAbridged")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LengthInMinutes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Locale")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureLarge")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("AudibleProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DataLayer.BookContributor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContributorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookId", "ContributorId", "Role");

                    b.HasIndex("BookId");

                    b.HasIndex("ContributorId");

                    b.ToTable("BookContributor");
                });

            modelBuilder.Entity("DataLayer.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AudibleCategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentCategoryCategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.HasIndex("AudibleCategoryId");

                    b.HasIndex("ParentCategoryCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = -1,
                            AudibleCategoryId = "",
                            Name = ""
                        });
                });

            modelBuilder.Entity("DataLayer.Contributor", b =>
                {
                    b.Property<int>("ContributorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AudibleContributorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ContributorId");

                    b.HasIndex("Name");

                    b.ToTable("Contributors");

                    b.HasData(
                        new
                        {
                            ContributorId = -1,
                            Name = ""
                        });
                });

            modelBuilder.Entity("DataLayer.LibraryBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Account")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("LibraryBooks");
                });

            modelBuilder.Entity("DataLayer.Series", b =>
                {
                    b.Property<int>("SeriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AudibleSeriesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("SeriesId");

                    b.HasIndex("AudibleSeriesId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("DataLayer.SeriesBook", b =>
                {
                    b.Property<int>("SeriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Order")
                        .HasColumnType("TEXT");

                    b.HasKey("SeriesId", "BookId");

                    b.HasIndex("BookId");

                    b.HasIndex("SeriesId");

                    b.ToTable("SeriesBook");
                });

            modelBuilder.Entity("DataLayer.Book", b =>
                {
                    b.HasOne("DataLayer.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DataLayer.Rating", "Rating", b1 =>
                        {
                            b1.Property<int>("BookId")
                                .HasColumnType("INTEGER");

                            b1.Property<float>("OverallRating")
                                .HasColumnType("REAL");

                            b1.Property<float>("PerformanceRating")
                                .HasColumnType("REAL");

                            b1.Property<float>("StoryRating")
                                .HasColumnType("REAL");

                            b1.HasKey("BookId");

                            b1.ToTable("Books");

                            b1.WithOwner()
                                .HasForeignKey("BookId");
                        });

                    b.OwnsMany("DataLayer.Supplement", "Supplements", b1 =>
                        {
                            b1.Property<int>("SupplementId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<int>("BookId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Url")
                                .HasColumnType("TEXT");

                            b1.HasKey("SupplementId");

                            b1.HasIndex("BookId");

                            b1.ToTable("Supplement");

                            b1.WithOwner("Book")
                                .HasForeignKey("BookId");

                            b1.Navigation("Book");
                        });

                    b.OwnsOne("DataLayer.UserDefinedItem", "UserDefinedItem", b1 =>
                        {
                            b1.Property<int>("BookId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("BookStatus")
                                .HasColumnType("INTEGER");

                            b1.Property<int?>("PdfStatus")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Tags")
                                .HasColumnType("TEXT");

                            b1.HasKey("BookId");

                            b1.ToTable("UserDefinedItem", (string)null);

                            b1.WithOwner("Book")
                                .HasForeignKey("BookId");

                            b1.OwnsOne("DataLayer.Rating", "Rating", b2 =>
                                {
                                    b2.Property<int>("UserDefinedItemBookId")
                                        .HasColumnType("INTEGER");

                                    b2.Property<float>("OverallRating")
                                        .HasColumnType("REAL");

                                    b2.Property<float>("PerformanceRating")
                                        .HasColumnType("REAL");

                                    b2.Property<float>("StoryRating")
                                        .HasColumnType("REAL");

                                    b2.HasKey("UserDefinedItemBookId");

                                    b2.ToTable("UserDefinedItem");

                                    b2.WithOwner()
                                        .HasForeignKey("UserDefinedItemBookId");
                                });

                            b1.Navigation("Book");

                            b1.Navigation("Rating");
                        });

                    b.Navigation("Category");

                    b.Navigation("Rating");

                    b.Navigation("Supplements");

                    b.Navigation("UserDefinedItem");
                });

            modelBuilder.Entity("DataLayer.BookContributor", b =>
                {
                    b.HasOne("DataLayer.Book", "Book")
                        .WithMany("ContributorsLink")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Contributor", "Contributor")
                        .WithMany("BooksLink")
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Contributor");
                });

            modelBuilder.Entity("DataLayer.Category", b =>
                {
                    b.HasOne("DataLayer.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("DataLayer.LibraryBook", b =>
                {
                    b.HasOne("DataLayer.Book", "Book")
                        .WithOne()
                        .HasForeignKey("DataLayer.LibraryBook", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataLayer.SeriesBook", b =>
                {
                    b.HasOne("DataLayer.Book", "Book")
                        .WithMany("SeriesLink")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Series", "Series")
                        .WithMany("BooksLink")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("DataLayer.Book", b =>
                {
                    b.Navigation("ContributorsLink");

                    b.Navigation("SeriesLink");
                });

            modelBuilder.Entity("DataLayer.Contributor", b =>
                {
                    b.Navigation("BooksLink");
                });

            modelBuilder.Entity("DataLayer.Series", b =>
                {
                    b.Navigation("BooksLink");
                });
#pragma warning restore 612, 618
        }
    }
}
