using OnlibraryDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlibraryDataAccess.Data
{
    public class Translation: TranslationBase
    {
        public BookBase Book { get; set; }
        public List<LanguageBase> Languages { get; set; }
    }
}
