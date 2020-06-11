using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GamedevStorage.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult IndexInfo()
        {
            return View("Info");
        }
    }
}