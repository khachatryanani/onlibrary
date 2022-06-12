using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OnlibraryDataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<AuthorBase> GetAuthors()
        {
           // return new List<string>() { "some", "strings" };
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetAuthors]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var authors = new List<AuthorBase>();
                        if (reader.HasRows)
                        {
                            int authorId = reader.GetOrdinal("AuthorId");
                            int authorFirstName = reader.GetOrdinal("AuthorFirstName");
                            int authorLastName = reader.GetOrdinal("AuthorLastName");
                            int authorNationality = reader.GetOrdinal("Nationality");
                            int authorCountry = reader.GetOrdinal("Country");
                            int authorRating = reader.GetOrdinal("Rating");

                            while (reader.Read())
                            {
                                authors.Add(
                                    new AuthorBase
                                    {
                                        AuthorId = reader.GetInt32(authorId),
                                        AuthorFirstName = reader.GetString(authorFirstName),
                                        AuthorLastName = reader.GetString(authorLastName),
                                        Nationality = reader.GetString(authorNationality),
                                        Country = reader.GetString(authorCountry),
                                        Rating = reader.GetInt32(authorRating),
                                    });
                            }
                        }

                        return authors;
                    }
                }
            }


        }

        public AuthorBase GetAuthorById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetAuthorById]";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var authors = new List<AuthorBase>();
                        if (reader.HasRows)
                        {
                            int authorId = reader.GetOrdinal("AuthorId");
                            int authorFirstName = reader.GetOrdinal("AuthorFirstName");
                            int authorLastName = reader.GetOrdinal("AuthorLastName");
                            int authorNationality = reader.GetOrdinal("Nationality");
                            int authorCountry = reader.GetOrdinal("Country");
                            int authorRating = reader.GetOrdinal("Rating");

                            while (reader.Read())
                            {
                                authors.Add(
                                    new AuthorBase
                                    {
                                        AuthorId = reader.GetInt32(authorId),
                                        AuthorFirstName = reader.GetString(authorFirstName),
                                        AuthorLastName = reader.GetString(authorLastName),
                                        Nationality = reader.GetString(authorNationality),
                                        Country = reader.GetString(authorCountry),
                                        Rating = reader.GetInt32(authorRating),
                                    });
                            }
                        }

                        return authors.FirstOrDefault();
                    }
                }
            }
        }

        public AuthorBase GetAuthorByName(string firstname, string lastName)
        {
            return new AuthorBase();
        }

        public void CreatAuthor(Author author) 
        {

        }

        public IEnumerable<BookBase> GetBooks()
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetBooks]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var books = new List<BookBase>();
                        if (reader.HasRows)
                        {
                            int bookId = reader.GetOrdinal("BookId");
                            int title = reader.GetOrdinal("Title");
                            int year = reader.GetOrdinal("Year");
                            int pages = reader.GetOrdinal("Pages");
                            int rating = reader.GetOrdinal("Rating");
                            int authorId = reader.GetOrdinal("AuthorId");

                            while (reader.Read())
                            {
                                books.Add(
                                    new BookBase
                                    {
                                        BookId = reader.GetInt32(bookId),
                                        Title = reader.GetString(title),
                                        Year = reader.GetInt32(year),
                                        Pages = reader.GetInt32(pages),
                                        Rating = reader.GetInt32(rating),
                                        AuthorId = reader.GetInt32(authorId),
                                    });
                            }
                        }

                        return books;
                    }
                }
            }
        }

        public BookBase GetBookById(int id)
        {
            return new BookBase();
        }

        public BookBase GetBookByTitle(string title)
        {
            return new BookBase();
        }

        public void CreateBook(Book book) 
        {

        }

        public void CreateTranslation(Translation translation) 
        {

        }

        public IEnumerable<Book> GetCollection() 
        {
            List<Book> collection = new List<Book>();
            IEnumerable < BookBase > books = GetBooks();
            foreach (var book in books)
            {
                List<LanguageBase> languages = new List<LanguageBase>(GetTranslationsByBookId(book.BookId));
                AuthorBase author = GetAuthorById(book.AuthorId);
                collection.Add(new Book(book, author.AuthorFirstName + " " + author.AuthorLastName, new Translation() { Book = book, Languages = languages }));

            }

            return collection;
        }

        public IEnumerable<Author> GetLibrary() 
        {
            var library = new List<Author>();
            var authors = GetAuthors();

            foreach (var author in authors)
            {
                var books = GetBooksByAuthorId(author.AuthorId);
                var collaction = new List<Book>();
                foreach (var book in books)
                {
                    var langauges = new List<LanguageBase>(GetTranslationsByBookId(book.BookId));
                    collaction.Add(new Book(book, author.AuthorFirstName + " "+ author.AuthorLastName, new Translation() { Book = book, Languages = langauges }));
                }

                library.Add(new Author(author, collaction));
            }

            return library;

            //return new List<Author>();
        }

        public IEnumerable<LanguageBase> GetTranslationsByBookId(int bookId) 
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetTranslationByBookId]";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = bookId;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var languages = new List<LanguageBase>();
                        if (reader.HasRows)
                        {
                            int langaugeId = reader.GetOrdinal("LanguageId");
                            int langauge = reader.GetOrdinal("Language");
                            while (reader.Read())
                            {
                                languages.Add(
                                    new LanguageBase
                                    {
                                        LanguageId = reader.GetInt32(langaugeId),
                                        Language = reader.GetString(langauge),
                                    });
                            }
                        }

                        return languages;
                    }
                }
            }
        }

        public IEnumerable<BookBase> GetBooksByAuthorId(int authorId) 
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetBooksByAuthorId]";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = authorId;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var books = new List<BookBase>();
                        if (reader.HasRows)
                        {
                            int bookId = reader.GetOrdinal("BookId");
                            int title = reader.GetOrdinal("Title");
                            int year = reader.GetOrdinal("Year");
                            int pages = reader.GetOrdinal("Pages");
                            int rating = reader.GetOrdinal("Rating");

                            while (reader.Read())
                            {
                                books.Add(
                                    new BookBase
                                    {
                                        BookId = reader.GetInt32(bookId),
                                        Title = reader.GetString(title),
                                        Year = reader.GetInt32(year),
                                        Pages = reader.GetInt32(pages),
                                        Rating = reader.GetInt32(rating),
                                        AuthorId = authorId
                                    });
                            }
                        }

                        return books;
                    }
                }
            }
        }
    }
}
