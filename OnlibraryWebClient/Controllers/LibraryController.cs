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
        private readonly GraphQLHttpClient _client;
        public LibraryController(GraphQLHttpClient client)
        {
            _client = client;
        }


        public async Task<IActionResult> Index()
        {
            var request = new GraphQLHttpRequest()
            {
                Query = @"query {library {authorId,authorFirstName,authorLastName,rating,country,nationality,books {bookId,title,year,translations {languages {language}}}}}"
            };

            var response = await _client.SendQueryAsync<Library>(request);
            var result = response.Data;
            return View(result);
        }
    }
}
