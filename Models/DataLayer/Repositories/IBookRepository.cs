﻿namespace BookStore.Models
{
    public interface IBookRepository : IRepository<Book>
    {
        void AddUpdateAuthors(Book book, int[] authorId, IRepository<Author> authorData);


    }
}
