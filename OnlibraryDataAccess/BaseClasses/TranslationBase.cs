using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess.BaseClasses
{
    public class TranslationBase
    {
        public int TranslationId { get; set; }
        public int BookId { get; set; }
        public int LanguageId { get; set; }
    }
}
