using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UALMonitor.DAL
{
    class ProductionDBContext:DbContext
    {
        public ProductionDBContext() : base("ProductionDB") { }
    }
}
