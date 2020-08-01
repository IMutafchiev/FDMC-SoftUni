using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC_MVC.App.ViewModels.Cats.BindingModels;
using FDMC_MVC.App.ViewModels.Cats.ViewModels;
using FDMC_MVC.Data;
using FDMC_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDMC_MVC.App.Controllers
{
    public class CatsController : Controller
    {
        private readonly FDMCDbContext dbContext;

        public CatsController(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var Cat = this.dbContext.Cats.FirstOrDefault(c => c.Id == id);

            var viewModel = new CatDetailsViewModel
            {
                Name = Cat.Name,
                Age = Cat.Age,
                Breed = Cat.Breed,
                ImageUrl = Cat.ImageUrl
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CreateCatBindingModel CatModel)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var Cat = new Cat
            {
                Name = CatModel.Name,
                Age = CatModel.Age,
                Breed = CatModel.Breed,
                ImageUrl = CatModel.ImageUrl
            };

            this.dbContext.Cats.Add(Cat);
            this.dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}