using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.AspNetCore.Mvc;
using OnlibraryWebClient.Models;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlibraryAPI.Models;

namespace OnlibraryWebClient.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new GraphQLHttpClient("https://localhost:5001/graphql", new NewtonsoftJsonSerializer());
            var request = new GraphQLHttpRequest()
            {
                Query = @"query {library {authorId,authorFirstName,authorLastName,rating,country,nationality,books {bookId,title,year,translations {languages {language}}}}}"
            };

            var response = await client.SendQueryAsync<Library>(request);
            var result = response.Data;
            return View(result);
        }
    }
}
