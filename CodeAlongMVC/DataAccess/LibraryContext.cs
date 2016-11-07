using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.DataAccess
{
    public class LibraryContext :DbContext
    {
        public LibraryContext() : base("DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}