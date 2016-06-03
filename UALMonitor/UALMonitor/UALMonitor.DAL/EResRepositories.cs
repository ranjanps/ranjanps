using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UALMonitor.Domain;

namespace UALMonitor.DAL
{
    public static class EResRepositories
    {
        static private IEjFlightLookupRepository flightRepo;

        static EResRepositories()
        {
            flightRepo= new EjFlightLookupRepository();
        }

        public static IEnumerable<Airport> GetAirports()
        {
            return flightRepo.GetAirports();
        }

        public static Airport GetAirportById(int airportId)
        {
            var airport = (from a in flightRepo.GetAirports()
                           where a.AirportCodeId == airportId
                           select a).FirstOrDefault();
            return airport;
        }

        public static IEnumerable<Airport> GetAirportsByCountry(string countryCode)
        {
            var airports = (from a in flightRepo.GetAirports()
                           where a.CountryCode == countryCode
                           select a).ToList();
            return airports;
        }


        public static IEnumerable<Country> GetCountries()
        {
            var result = (from a in flightRepo.GetCountries()
                            select a).ToList();
            return result;
        }


        public static IEnumerable<Route> GetRoutes()
        {
            var result = (from a in flightRepo.GetRoutes()
                          select a).ToList();
            return result;
        }


        public static IEnumerable<Airport> GetRoutesByAirport(string airportCode)
        {

            var airportCodeId = (from a in flightRepo.GetAirports()
                                 where a.AirportCode == airportCode
                                 select a).FirstOrDefault().AirportCodeId;

            var result = (from a in flightRepo.GetRoutes()
                          join d in flightRepo.GetAirports() on a.DepAirportCodeID equals d.AirportCodeId
                          where a.ArrAirportCodeID == airportCodeId
                          select d).ToList();
            return result;
        }



    }
}
