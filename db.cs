 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace _15
{
    public class db:DbContext
    {
      public db() : base("rt")
        {

        }
        public DbSet<sing_up> sing_ups { get; set;}
    }
}
