using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UALMonitor.Domain;

namespace UALMonitor.DAL
{
    public interface IEjFlightLookupRepository
    {
        IEnumerable<Airport> GetAirports();

        IEnumerable<Route> GetRoutes();

        IEnumerable<Country> GetCountries();

        IEnumerable<Currency> GetCurrencies();

        IEnumerable<Equipment> GetEquipments();



    }
}
