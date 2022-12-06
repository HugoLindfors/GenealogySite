using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenealogySite.Models;

    public class GenealogySiteContext : DbContext
    {
        public GenealogySiteContext (DbContextOptions<GenealogySiteContext> options)
            : base(options)
        {
        }

        public DbSet<GenealogySite.Models.Person> Person { get; set; }
    }
