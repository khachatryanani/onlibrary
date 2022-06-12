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
    public class TranslationResolver
    {
        private readonly IDataAccess dataAccess;
        public TranslationResolver([Service]
        IDataAccess dataAcc)
        {
            dataAccess = dataAcc;
        }

        public List<LanguageBase> GetTranslations(
        BookBase book, IResolverContext ctx)
        {
            var languages = dataAccess.GetTranslationsByBookId(book.BookId);

            return new List<LanguageBase>(languages);
        }
    }
}
