using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FDMC_MVC.App.ViewModels;
using FDMC_MVC.Data;
using FDMC_MVC.App.ViewModels.Home;

namespace FDMC_MVC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly FDMCDbContext dbContext;

        public HomeController(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Cats = this.dbContext.Cats.ToList()
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
