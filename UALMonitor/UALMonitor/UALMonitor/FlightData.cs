using System;
using System.Windows.Forms;
using UALMonitor.DAL;
using UALMonitor.Domain;
using System.Collections;
using System.Collections.Generic;


namespace UALMonitor
{
    public partial class FlightData : Form
    {

        private IEnumerable<Airport> _airports;
        private IEnumerable<Country> _countries;


        public FlightData()
        {
            InitializeComponent();

            _airports = EResRepositories.GetAirports();
            _countries = EResRepositories.GetCountries();
            

            LoadDropDowns();
        }

        private void LoadDropDowns()
        {
            IList sourceCountries = _countries as IList;
            sourceCountries.Add(new Country { CountryCode = "", CountryId = -1, CountryName = "Select All" });

            IList destCountries = _countries as IList;
            destCountries.Add(new Country { CountryCode = "", CountryId = -1, CountryName = "Select All" });

            cmbFromCountry.DataSource = sourceCountries;
            cmbFromCountry.DisplayMember = "CountryName";
            cmbFromCountry.ValueMember = "CountryCode";
            
            cmbFromCountry.SelectedText = "Select All";

            cmbToCountry.DataSource = destCountries;
            cmbToCountry.DisplayMember = "CountryName";
            cmbToCountry.ValueMember = "CountryCode";
            cmbToCountry.SelectedText = "Select All";

            cmbFromAirport.DataSource = _airports;
            cmbFromAirport.DisplayMember = "DisplayName";
            cmbFromAirport.ValueMember = "AirportCodeId";

            cmbToAirport.DataSource = _airports;
            cmbToAirport.DisplayMember = "DisplayName";
            cmbToAirport.ValueMember = "AirportCodeId";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var result = EResRepositories.GetAirports();
              
        }

        private void cmbFromCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Airport> filteredAirports;

            if (cmbFromCountry.SelectedValue.ToString() != "")
                filteredAirports = EResRepositories.GetAirportsByCountry(cmbFromCountry.SelectedValue.ToString());
            else
                filteredAirports = _airports;

            cmbFromAirport.DataSource = filteredAirports;
            cmbFromAirport.DisplayMember = "DisplayName";
            cmbFromAirport.ValueMember = "AirportCodeId";

        }

        private void cmbToCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Airport> filteredAirports;

            if (cmbFromCountry.SelectedValue.ToString() != "")
                filteredAirports = EResRepositories.GetAirportsByCountry(cmbToCountry.SelectedValue.ToString());
            else
                filteredAirports = _airports;

            cmbToAirport.DataSource = filteredAirports;
            cmbToAirport.DisplayMember = "DisplayName";
            cmbToAirport.ValueMember = "AirportCodeId";
        }
    }


}

