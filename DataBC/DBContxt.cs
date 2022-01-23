using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBC
{
    public class DBContxt : DbContext
    {
        public DBContxt(DbContextOptions o) : base(o) { }
        public DbSet<Kamer> rooms { get; set; }
    }
}
