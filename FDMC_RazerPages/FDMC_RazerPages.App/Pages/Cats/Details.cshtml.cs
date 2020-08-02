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
    public class DetailsModel : PageModel
    {
        private readonly FDMCDbContext dbContext;

        public Cat Cat;

        public DetailsModel(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnGet(int id)
        {
            this.Cat = this.dbContext.Cats.FirstOrDefault(c => c.Id == id);
        }
    }
}