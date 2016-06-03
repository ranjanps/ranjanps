using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UALMonitor.Domain
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }

        public string CurrencyCodeDescription { get; set; }

        public string Country { get; set; }

        public int CountryCodeID { get; set; }

    }
}
