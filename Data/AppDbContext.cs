using Microsoft.EntityFrameworkCore;
using Renzorapi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renzorapi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        } 
        public DbSet<Poem> Poems { get; set; }
        
    }
}
