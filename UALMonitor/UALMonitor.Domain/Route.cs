using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UALMonitor.Domain
{
    public class Route
    {
        public int RouteID { get; set; }

        public int DepAirportCodeID { get; set; }

        public int ArrAirportCodeID { get; set; }

        public string APISFlag { get; set; }

        public DateTime? APISCheckInActiveDate { get; set; }

        public string ArrAPISFlag { get; set; }

        public string DepAPISFlag { get; set; }

        public string ICTSFlag { get; set; }

        public DateTime? ICTSActiveDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string RouteData { get; set; }

    }
}
