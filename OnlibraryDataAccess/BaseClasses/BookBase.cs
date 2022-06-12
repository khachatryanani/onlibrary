using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess.BaseClasses
{
    public class BookBase
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; }
    }
}
