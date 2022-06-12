using Microsoft.AspNetCore.Mvc;
using OnlibraryDataAccess;
using OnlibraryDataAccess.BaseClasses;
using OnlibraryDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : Controller
    {
        private readonly IDataAccess _dataRep;

        public AuthorsController(IDataAccess dataRepository)
        {
            _dataRep = dataRepository;
        }

        [HttpGet]
        public IEnumerable<AuthorBase> GetUsers()
        {
            return _dataRep.GetAuthors();
        }
    }
}
