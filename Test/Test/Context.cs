using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Test
{
    public class Context : DbContext
    {     
        public Context(): base("DbConnection") { }
        public DbSet<Weather> WeatherByMonth { get; set; }
        public DbSet<DataList> WeatherByDate { get; set; }
    }
}
