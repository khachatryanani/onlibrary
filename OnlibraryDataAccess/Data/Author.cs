using OnlibraryDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess.Data
{
    public class Author: AuthorBase
    {
       public IEnumerable<Book> Books { get; set; }

        public Author(AuthorBase authorBase, List<Book> books)
        {
            this.AuthorId = authorBase.AuthorId;
            this.AuthorFirstName = authorBase.AuthorFirstName;
            this.AuthorLastName = authorBase.AuthorLastName;
            this.Nationality = authorBase.Nationality;
            this.Country = authorBase.Country;
            this.Rating = authorBase.Rating;
            this.Books = books;
        }

        public Author()
        {

        }
    }
}
