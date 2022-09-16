using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP2.DB
{
    class SoccerContext : DbContext
    {
        public SoccerContext()
         : base("DefaultConnection")
        { }

        public DbSet<Player> PlayerSaps { get; set; }
    }
}
