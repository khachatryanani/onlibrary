using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.AspNetCore.Mvc;
using OnlibraryDataAccess.Data;
using OnlibraryWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryWebClient.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new GraphQLHttpClient("https://localhost:5001/graphql", new NewtonsoftJsonSerializer());
            var request = new GraphQLHttpRequest()
            {
                Query = @"query {collection {
    bookId
    title
    year
    pages
    rating
    authorName
    translations {
      languages {
        language
      }
    }
  }}"
            };

            var response = await client.SendQueryAsync<Collection>(request);
            var result = response.Data;
            return View(result);
        }
    }
}
