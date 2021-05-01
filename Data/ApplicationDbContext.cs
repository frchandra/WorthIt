﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorthIt.Models;

namespace WorthIt.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option): base(option)
        {

        }
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }


    }
}
