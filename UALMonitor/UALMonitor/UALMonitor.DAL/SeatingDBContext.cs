using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UALMonitor.DAL
{
    public class SeatingDBContext:DbContext
    {
        public SeatingDBContext() : base("SeatingDB") { }
    }
}
