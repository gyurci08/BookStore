﻿using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookStoreContext : DbContext
    {

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
                   : base(options)
        { }

        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure entities
            modelBuilder.ApplyConfiguration(new ConfigureGenres());
            modelBuilder.ApplyConfiguration(new ConfigureBooks());
            modelBuilder.ApplyConfiguration(new ConfigureAuthors());
            modelBuilder.ApplyConfiguration(new ConfigureBookAuthors());
        }


    }
}
