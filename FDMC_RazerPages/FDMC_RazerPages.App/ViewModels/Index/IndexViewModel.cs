using FDMC_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDMC_RazerPages.App.ViewModels.Index
{
    public class IndexViewModel
    {
        public IEnumerable<Cat> Cats { get; set; }
    }
}
