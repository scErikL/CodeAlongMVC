using CodeAlongMVC.DataAccess;
using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Repositories
{
    public class BookRepository
    {
        
        private LibraryContext context; 


        public BookRepository()
        {
            this.context = new LibraryContext();
            //Seed();
        }

        /*private void Seed()
        {
            books.Add(new Book { Id = 1, Author = "Ed McBain", Description = "Thriller", Title = "Trespass", Isbn = "111-111" });
            books.Add(new Book { Id = 2, Author = "Michael Connelly", Description = "Thriller", Title = "The Poet", Isbn = "111-112" });
            books.Add(new Book { Id = 3, Author = "Astrid Lindgren", Description = "Adventure", Title = "Pippi Longstocking", Isbn = "111-113" });
            books.Add(new Book { Id = 4, Author = "Ed McBain", Description = "Thriller", Title = "Red Rain", Isbn = "111-114" });
            books.Add(new Book { Id = 5, Author = "Astrid Lindgren", Description = "Adventure", Title = "Emil in Lonneberga", Isbn = "111-115" });
        }*/

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
            //return this.books;
        }

        public Book GetBookById(int id)
        {
            var retValue = context.Books.FirstOrDefault(b => b.Id == id);
            return retValue;
            //return this.books.FirstOrDefault(b => b.Id == id);
        }


    }
}