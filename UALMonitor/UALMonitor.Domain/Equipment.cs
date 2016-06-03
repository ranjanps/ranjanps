using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UALMonitor.Domain
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        public string AircraftConfig { get; set; }
        public string AircraftDescription { get; set; }
        public int MaxSeats { get; set; }
        public string AircraftType { get; set; }
    }
}
