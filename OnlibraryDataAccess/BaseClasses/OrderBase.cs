using System;
using System.Collections.Generic;
using System.Text;

namespace OnlibraryDataAccess.BaseClasses
{
    public class OrderBase
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public int BookLanguageId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public int Country { get; set; }
    }
}
