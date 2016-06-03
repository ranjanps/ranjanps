using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UALMonitor.Domain
{
    public class Airport
    {
        [Key]
        public int AirportCodeId { get; set; }
        public string AirportName { get; set; }
        public string AirportCode { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string DisplayName
        {
            get
            {
                return AirportName + "(" + AirportCode + ")";
            }
        }

    }
}
