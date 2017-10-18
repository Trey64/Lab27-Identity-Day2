using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab27Tom.Models
{
    public class Lab27TomContext : DbContext
    {
        public Lab27TomContext (DbContextOptions<Lab27TomContext> options)
            : base(options)
        {
        }

        public DbSet<Lab27Tom.Models.LFG> LFG { get; set; }
    }
}
