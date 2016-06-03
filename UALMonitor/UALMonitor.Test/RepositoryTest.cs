using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UALMonitor.DAL;
using UALMonitor.Domain;

namespace UALMonitor.Test
{
    /// <summary>
    /// Summary description for RepositoryTest
    /// </summary>
    [TestClass]
    public class RepositoryTest
    {
        public RepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
              

        [TestMethod]
        public void GetAirportsTest()
        {
            var st = EResRepositories.GetAirports();

            Assert.IsNotNull(st);
        }

        [TestMethod]

        public void GetRoutesByAirportTest()
        {
            var result = EResRepositories.GetRoutesByAirport("LTN");

            var r1 = result as ICollection<Airport>;


            Assert.IsNotNull(result);
            Assert.IsTrue(r1.Count > 1);
        }
    }
}
