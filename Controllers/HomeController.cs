using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTestingWebApp.Models;

namespace MyTestingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addtest()
        {
            return View();
        }

        public IActionResult insertest(string testname, string testtype, string testxpath1, string testxpath2,string teststatus)
        {
            testdetail test = new testdetail();
            test.testname = testname;
            test.testtype = testtype;
            test.testxpath1 = testxpath1;
            test.testxpath2 = testxpath2;
            test.teststatus = teststatus;

            return View("addtest");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
