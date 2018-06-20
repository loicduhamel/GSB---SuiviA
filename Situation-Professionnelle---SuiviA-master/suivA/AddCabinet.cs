using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleDirections;

namespace suivA
{
    public partial class AddCabinet : Form
    {
        public AddCabinet()
        {
            InitializeComponent();
        }

        // Fonction qui ajoute un cabinet a la BDD et qui utilise l'API Google Maps
        private void validerbutton_Click(object sender, EventArgs e)
        {
            var geocoder = new Geocoder("AIzaSyDoOuaAcFk-apUd7qNPaVnJcPV7a8iUTn0");
            var locations = geocoder.Geocode(adresseBox.Text);
            string lat = locations.First().LatLng.Latitude.ToString();
            string lon = locations.First().LatLng.Longitude.ToString();
            string adresse = locations.First().LocationName.ToString().Split(',').First();
            string request = "insert into cabinet (adresse,code_postal,ville,latitude,longitude) values (\"" + adresse + "\",\"" + cPostalBox.Text + "\",\"" + villeBox.Text + "\",\"" + lat + "\",\"" + lon + "\")";
            BddRequest newCabinet = new BddRequest();
            newCabinet.DataRequest(request);
            this.Close();
        }
    }
}