using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryAPI.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
    }
}
