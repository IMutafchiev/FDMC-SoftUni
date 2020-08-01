using FDMC_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDMC_MVC.App.ViewModels.Home
{
    public class IndexViewModel
    {
       public IEnumerable<Cat> Cats { get; set; }
    }
}
