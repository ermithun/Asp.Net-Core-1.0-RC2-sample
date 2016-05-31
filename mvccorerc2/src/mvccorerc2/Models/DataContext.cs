﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvccorerc2.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
