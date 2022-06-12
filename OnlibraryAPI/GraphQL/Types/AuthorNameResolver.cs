using HotChocolate;
using HotChocolate.Resolvers;
using OnlibraryDataAccess;
using OnlibraryDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.GraphQL.Types
{
    public class AuthorNameResolver
    {
        private readonly IDataAccess dataAccess;
        public AuthorNameResolver([Service]
        IDataAccess dataAcc)
        {
            dataAccess = dataAcc;
        }
        public string GetAuthorName(
        BookBase book, IResolverContext ctx)
        {
            var author =  dataAccess.GetAuthorById(book.AuthorId);

            return author.AuthorFirstName + " " + author.AuthorLastName;
        }
    }
}
