using System;
using System.Collections.Generic;
using System.Linq;
using UALMonitor.Domain;

namespace UALMonitor.DAL
{
    public class EjFlightLookupRepository : IEjFlightLookupRepository
    {
        private ProductionDBContext proddb;

        public EjFlightLookupRepository()
        {
            proddb = new ProductionDBContext();
        }

        public Airport GetAirport(string AirportCode)
        {
            var data = proddb.Database.SqlQuery<Airport>(@"SELECT 
                                                        AirportCodeId,
                                                        AirportName,
                                                        AirportCode,
                                                        City ,
                                                        Country,
                                                        CountryCode
                                                        from ejFlight.dbo.AirportCode (NOLOCK) where InUseFlag='Y' and AirportCode='" + AirportCode + "'").FirstOrDefault();
            return data;
        }

        public Airport GetAirport(int AirportId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Airport> GetAirports()
        {
           List<Airport> data = proddb.Database.SqlQuery<Airport>(@"SELECT 
                                                        AirportCodeId,
                                                        AirportName,
                                                        AirportCode,
                                                        City ,
                                                        Country,
                                                        CountryCode
                                                        from ejFlight.dbo.AirportCode (NOLOCK) where InUseFlag='Y'
                                                        ").ToList();
            return data;
        }

        public IEnumerable<Country> GetCountries()
        {
            return proddb.Database.SqlQuery<Country>(@"SELECT CountryId = CountryCodeId,CountryName,CountryCode from ejFlight.dbo.CountryCode (NOLOCK) where ActiveFlag='Y'").ToList();
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return proddb.Database.SqlQuery<Currency>(@"SELECT CurrencyId = CurrencyCodeId,CurrencyCode,CurrencyCodeDescription,Country,CountryCodeID from ejFlight.dbo.CurrencyCode (NOLOCK) where InUseFlag='Y'").ToList();
        }

        public IEnumerable<Equipment> GetEquipments()
        {
            return proddb.Database.SqlQuery<Equipment>(@"SELECT EquipmentId, AircraftConfig,AircraftDescription,MaxSeats,AircraftType from ejFlight..Equipment (NOLOCK)").ToList();
        }

        public IEnumerable<Route> GetRoutes()
        {
            return proddb.Database.SqlQuery<Route>(@"select RouteID,DepAirportCodeID,ArrAirportCodeID,APISFlag,APISCheckInActiveDate,ArrAPISFlag,DepAPISFlag,ICTSFlag,ICTSActiveDate,StartDate,EndDate,RouteData = Route from ejFlight.dbo.Routes (NOLOCK) where ActiveFlag='Y'").ToList();
        }
    }
}
