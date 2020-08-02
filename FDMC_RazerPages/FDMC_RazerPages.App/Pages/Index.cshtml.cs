using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC_RazerPages.App.ViewModels.Index;
using FDMC_RazerPages.Data;
using FDMC_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FDMC_RazerPages.App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FDMCDbContext dbContext;

        public IEnumerable<Cat> Cats;

        public IndexModel(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Cats = new List<Cat>();
        }

        public void OnGet()
        {
            var viewModel = new IndexViewModel
            {
                Cats = this.dbContext.Cats.ToList()
            };

            this.Cats = viewModel.Cats;
        }
    }
}
