
using HotChocolate;
using OnlibraryAPI.GraphQL.Types;
using OnlibraryDataAccess;
using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.GraphQL.Queries
{
    public class LibraryQuery
    {
        private readonly IDataAccess dataAccess;

        public async Task<List<AuthorBase>>
        GetAuthors([Service]
        IDataAccess authorRepository)
        {
            List<AuthorBase> authors =new List<AuthorBase>(authorRepository.GetAuthors());
            return authors;
        }

        public async Task<List<Author>>
        GetLibrary([Service]
        IDataAccess authorRepository)
        {
            List<Author> authors = new List<Author>(authorRepository.GetLibrary());
            return authors;
        }

        public async Task<List<BookBase>>
        GetBooks([Service]
        IDataAccess authorRepository)
        {
            List<BookBase> collection = new List<BookBase>(authorRepository.GetBooks());
            return collection;
        }

        public async Task<List<Book>>
         GetCollection([Service]
        IDataAccess authorRepository)
        {
            List<Book> collection = new List<Book>(authorRepository.GetCollection());
            return collection;
        }
    }
}
