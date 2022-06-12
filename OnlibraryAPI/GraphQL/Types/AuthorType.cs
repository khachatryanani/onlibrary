using HotChocolate.Types;
using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.GraphQL.Types
{
    public class AuthorType : ObjectType<AuthorBase>
    {
        protected override void Configure(IObjectTypeDescriptor<AuthorBase> descriptor)
        {
            descriptor.Field(a => a.AuthorId).Type<IdType>();
            descriptor.Field(a => a.AuthorFirstName).Type<StringType>();
            descriptor.Field(a => a.AuthorLastName).Type<StringType>();
            descriptor.Field(a => a.Nationality).Type<StringType>();
            descriptor.Field(a => a.Country).Type<StringType>();
            descriptor.Field(a => a.Rating).Type<IntType>();
        }
    }
}
