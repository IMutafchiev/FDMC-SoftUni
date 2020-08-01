using FDMC_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FDMC_MVC.Data
{
    public class FDMCDbContext : DbContext
    {
        public FDMCDbContext(DbContextOptions<FDMCDbContext> options) :base(options)
        {

        }

        public DbSet<Cat> Cats { get; set; }
    }
}
