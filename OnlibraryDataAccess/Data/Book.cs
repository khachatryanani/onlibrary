using OnlibraryDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess.Data
{
    public class Book: BookBase
    {
        public string AuthorName { get; set; }
        public Translation Translations { get; set; }

        public Book(BookBase bookbase, string author, Translation translations)
        {
            this.BookId = bookbase.BookId;
            this.Title = bookbase.Title;
            this.Year = bookbase.Year;
            this.Pages = bookbase.Pages;
            this.Rating = bookbase.Rating;
            this.AuthorId = bookbase.AuthorId;
            this.Translations = translations;
            this.AuthorName = author;
        }

        public Book()
        {

        }
    }
}
