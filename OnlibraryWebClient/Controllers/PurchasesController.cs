using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlibraryWebClient.Controllers
{
    
    public class PurchasesController : Controller
    {
        [HttpPost]
        public IActionResult Index(int bookId)
        {
            return View();
        }
    }
}
