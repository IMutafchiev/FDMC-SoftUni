using System;
using System.Collections.Generic;
using System.Text;

namespace FDMC_RazorPages.Models
{
    public class Cat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string ImageUrl { get; set; }
    }
}
