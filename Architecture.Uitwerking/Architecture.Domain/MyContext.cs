using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain
{
    public class MyContext : DbContext
    {
        public DbSet<Beschikbaarheid> Beschikbaarheid { get; set; }

        public DbSet<Vakantie> VakantieDagen{ get; set; }

    }
}
