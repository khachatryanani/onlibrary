using HotChocolate.Types;
using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.GraphQL.Types
{
    public class BookType: ObjectType<BookBase>
    {
        protected override void Configure(IObjectTypeDescriptor<BookBase> descriptor)
        {
            descriptor.Field(b => b.BookId).Type<IdType>();
            descriptor.Field(b => b.Title).Type<StringType>();
            descriptor.Field(b => b.Year).Type<IntType>();
            descriptor.Field(b => b.Rating).Type<IntType>();
            descriptor.Field(b => b.Pages).Type<IntType>();
            descriptor.Field<AuthorNameResolver>(b => b.GetAuthorName(default, default));
            descriptor.Field<TranslationResolver>(b => new Translation() { Book = default, Languages = b.GetTranslations(default, default) } );
        }
    }
}
