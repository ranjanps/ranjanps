using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UALMonitor.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public int DepAirportCodeId { get; set; }
        public int ArrAirportCodeId { get; set; }
        public string FlightKey { get; set; }
        public DateTime LocalDepDtTm { get; set; }

        public int Capacity { get; set; }

        public int Lid { get; set; }

        public int IROP_Lid { get; set; }

        public int SeatsSold { get; set; }

        public int EquipmentId { get; set; }

        public int InfantCount { get; set; }

        public int InfantSold { get; set; }
        

    }
}
