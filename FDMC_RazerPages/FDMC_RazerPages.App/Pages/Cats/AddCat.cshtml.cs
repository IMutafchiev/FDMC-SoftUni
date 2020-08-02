using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC_RazerPages.Data;
using FDMC_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDMC_RazerPages.App.Pages.Cats
{
    public class AddCatModel : PageModel
    {

        private readonly FDMCDbContext dbContext;

        private Cat Cat;

        public AddCatModel(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string Name, int Age, string Breed, string ImageUrl)
        {

            this.Cat = new Cat
            {
                Name = Name,
                Age = Age,
                Breed = Breed,
                ImageUrl = ImageUrl
            };

            this.dbContext.Cats.Add(this.Cat);
            this.dbContext.SaveChanges();


            return RedirectToPage("/Index");
        }
    }
}