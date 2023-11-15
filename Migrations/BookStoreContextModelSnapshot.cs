﻿// <auto-generated />
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            AuthorsAuthorId = 18,
                            BooksBookId = 1
                        },
                        new
                        {
                            AuthorsAuthorId = 20,
                            BooksBookId = 2
                        },
                        new
                        {
                            AuthorsAuthorId = 7,
                            BooksBookId = 3
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 4
                        },
                        new
                        {
                            AuthorsAuthorId = 19,
                            BooksBookId = 5
                        },
                        new
                        {
                            AuthorsAuthorId = 8,
                            BooksBookId = 6
                        },
                        new
                        {
                            AuthorsAuthorId = 12,
                            BooksBookId = 7
                        },
                        new
                        {
                            AuthorsAuthorId = 16,
                            BooksBookId = 8
                        },
                        new
                        {
                            AuthorsAuthorId = 2,
                            BooksBookId = 9
                        },
                        new
                        {
                            AuthorsAuthorId = 20,
                            BooksBookId = 10
                        },
                        new
                        {
                            AuthorsAuthorId = 15,
                            BooksBookId = 11
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 12
                        },
                        new
                        {
                            AuthorsAuthorId = 21,
                            BooksBookId = 13
                        },
                        new
                        {
                            AuthorsAuthorId = 5,
                            BooksBookId = 14
                        },
                        new
                        {
                            AuthorsAuthorId = 9,
                            BooksBookId = 15
                        },
                        new
                        {
                            AuthorsAuthorId = 13,
                            BooksBookId = 16
                        },
                        new
                        {
                            AuthorsAuthorId = 7,
                            BooksBookId = 17
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 18
                        },
                        new
                        {
                            AuthorsAuthorId = 11,
                            BooksBookId = 19
                        },
                        new
                        {
                            AuthorsAuthorId = 22,
                            BooksBookId = 20
                        },
                        new
                        {
                            AuthorsAuthorId = 17,
                            BooksBookId = 21
                        },
                        new
                        {
                            AuthorsAuthorId = 3,
                            BooksBookId = 22
                        },
                        new
                        {
                            AuthorsAuthorId = 14,
                            BooksBookId = 23
                        },
                        new
                        {
                            AuthorsAuthorId = 1,
                            BooksBookId = 24
                        },
                        new
                        {
                            AuthorsAuthorId = 10,
                            BooksBookId = 25
                        },
                        new
                        {
                            AuthorsAuthorId = 6,
                            BooksBookId = 26
                        },
                        new
                        {
                            AuthorsAuthorId = 23,
                            BooksBookId = 27
                        },
                        new
                        {
                            AuthorsAuthorId = 4,
                            BooksBookId = 28
                        },
                        new
                        {
                            AuthorsAuthorId = 26,
                            BooksBookId = 28
                        },
                        new
                        {
                            AuthorsAuthorId = 25,
                            BooksBookId = 29
                        });
                });

            modelBuilder.Entity("BookStore.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Michelle",
                            LastName = "Alexander"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Stephen E.",
                            LastName = "Ambrose"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Margaret",
                            LastName = "Atwood"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Jane",
                            LastName = "Austen"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "James",
                            LastName = "Baldwin"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Emily",
                            LastName = "Bronte"
                        },
                        new
                        {
                            AuthorId = 7,
                            FirstName = "Agatha",
                            LastName = "Christie"
                        },
                        new
                        {
                            AuthorId = 8,
                            FirstName = "Ta-Nehisi",
                            LastName = "Coates"
                        },
                        new
                        {
                            AuthorId = 9,
                            FirstName = "Jared",
                            LastName = "Diamond"
                        },
                        new
                        {
                            AuthorId = 10,
                            FirstName = "Joan",
                            LastName = "Didion"
                        },
                        new
                        {
                            AuthorId = 11,
                            FirstName = "Daphne",
                            LastName = "Du Maurier"
                        },
                        new
                        {
                            AuthorId = 12,
                            FirstName = "Tina",
                            LastName = "Fey"
                        },
                        new
                        {
                            AuthorId = 13,
                            FirstName = "Roxane",
                            LastName = "Gay"
                        },
                        new
                        {
                            AuthorId = 14,
                            FirstName = "Dashiel",
                            LastName = "Hammett"
                        },
                        new
                        {
                            AuthorId = 15,
                            FirstName = "Frank",
                            LastName = "Herbert"
                        },
                        new
                        {
                            AuthorId = 16,
                            FirstName = "Aldous",
                            LastName = "Huxley"
                        },
                        new
                        {
                            AuthorId = 17,
                            FirstName = "Stieg",
                            LastName = "Larsson"
                        },
                        new
                        {
                            AuthorId = 18,
                            FirstName = "David",
                            LastName = "McCullough"
                        },
                        new
                        {
                            AuthorId = 19,
                            FirstName = "Toni",
                            LastName = "Morrison"
                        },
                        new
                        {
                            AuthorId = 20,
                            FirstName = "George",
                            LastName = "Orwell"
                        },
                        new
                        {
                            AuthorId = 21,
                            FirstName = "Mary",
                            LastName = "Shelley"
                        },
                        new
                        {
                            AuthorId = 22,
                            FirstName = "Sun",
                            LastName = "Tzu"
                        },
                        new
                        {
                            AuthorId = 23,
                            FirstName = "Augusten",
                            LastName = "Burroughs"
                        },
                        new
                        {
                            AuthorId = 25,
                            FirstName = "JK",
                            LastName = "Rowling"
                        },
                        new
                        {
                            AuthorId = 26,
                            FirstName = "Seth",
                            LastName = "Grahame-Smith"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = "history",
                            Price = 18.0,
                            Title = "1776"
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = "scifi",
                            Price = 5.5,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            GenreId = "mystery",
                            Price = 4.5,
                            Title = "And Then There Were None"
                        },
                        new
                        {
                            BookId = 4,
                            GenreId = "history",
                            Price = 11.5,
                            Title = "Band of Brothers"
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = "novel",
                            Price = 10.99,
                            Title = "Beloved"
                        },
                        new
                        {
                            BookId = 6,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "Between the World and Me"
                        },
                        new
                        {
                            BookId = 7,
                            GenreId = "memoir",
                            Price = 4.25,
                            Title = "Bossypants"
                        },
                        new
                        {
                            BookId = 8,
                            GenreId = "scifi",
                            Price = 16.25,
                            Title = "Brave New World"
                        },
                        new
                        {
                            BookId = 9,
                            GenreId = "history",
                            Price = 15.0,
                            Title = "D-Day"
                        },
                        new
                        {
                            BookId = 10,
                            GenreId = "memoir",
                            Price = 12.5,
                            Title = "Down and Out in Paris and London"
                        },
                        new
                        {
                            BookId = 11,
                            GenreId = "scifi",
                            Price = 8.75,
                            Title = "Dune"
                        },
                        new
                        {
                            BookId = 12,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Emma"
                        },
                        new
                        {
                            BookId = 13,
                            GenreId = "scifi",
                            Price = 6.5,
                            Title = "Frankenstein"
                        },
                        new
                        {
                            BookId = 14,
                            GenreId = "novel",
                            Price = 10.25,
                            Title = "Go Tell it on the Mountain"
                        },
                        new
                        {
                            BookId = 15,
                            GenreId = "history",
                            Price = 15.5,
                            Title = "Guns, Germs, and Steel"
                        },
                        new
                        {
                            BookId = 16,
                            GenreId = "memoir",
                            Price = 14.5,
                            Title = "Hunger"
                        },
                        new
                        {
                            BookId = 17,
                            GenreId = "mystery",
                            Price = 6.75,
                            Title = "Murder on the Orient Express"
                        },
                        new
                        {
                            BookId = 18,
                            GenreId = "novel",
                            Price = 8.5,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 19,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "Rebecca"
                        },
                        new
                        {
                            BookId = 20,
                            GenreId = "history",
                            Price = 5.75,
                            Title = "The Art of War"
                        },
                        new
                        {
                            BookId = 21,
                            GenreId = "mystery",
                            Price = 8.5,
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            BookId = 22,
                            GenreId = "scifi",
                            Price = 12.5,
                            Title = "The Handmaid's Tale"
                        },
                        new
                        {
                            BookId = 23,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "The Maltese Falcon"
                        },
                        new
                        {
                            BookId = 24,
                            GenreId = "history",
                            Price = 13.75,
                            Title = "The New Jim Crow"
                        },
                        new
                        {
                            BookId = 25,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "The Year of Magical Thinking"
                        },
                        new
                        {
                            BookId = 26,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Wuthering Heights"
                        },
                        new
                        {
                            BookId = 27,
                            GenreId = "memoir",
                            Price = 11.0,
                            Title = "Running With Scissors"
                        },
                        new
                        {
                            BookId = 28,
                            GenreId = "novel",
                            Price = 8.75,
                            Title = "Pride and Prejudice and Zombies"
                        },
                        new
                        {
                            BookId = 29,
                            GenreId = "novel",
                            Price = 9.75,
                            Title = "Harry Potter and the Sorcerer's Stone"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "novel",
                            Name = "Novel"
                        },
                        new
                        {
                            GenreId = "memoir",
                            Name = "Memoir"
                        },
                        new
                        {
                            GenreId = "mystery",
                            Name = "Mystery"
                        },
                        new
                        {
                            GenreId = "scifi",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            GenreId = "history",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("BookStore.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.HasOne("BookStore.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookStore.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}