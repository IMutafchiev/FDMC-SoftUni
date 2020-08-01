using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FDMC_MVC.App.ViewModels.Cats.BindingModels
{
    public class CreateCatBindingModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

    }
}
