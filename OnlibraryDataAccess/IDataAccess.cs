using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess
{
    public interface IDataAccess
    {
        public IEnumerable<AuthorBase> GetAuthors();

        public AuthorBase GetAuthorById(int id);

        public AuthorBase GetAuthorByName(string firstname, string lastName);

        public void CreatAuthor(Author author);

        public IEnumerable<BookBase> GetBooks();

        public BookBase GetBookById(int id);

        public BookBase GetBookByTitle(string title);

        public void CreateBook(Book book);

        public void CreateTranslation(Translation translation);

        public IEnumerable<Book> GetCollection();

        public IEnumerable<Author> GetLibrary();

        public IEnumerable<LanguageBase> GetTranslationsByBookId(int bookId);

        public IEnumerable<BookBase> GetBooksByAuthorId(int authorId);
    }
}
