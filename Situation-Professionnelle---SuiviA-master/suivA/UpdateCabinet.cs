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
    public partial class UpdateCabinet : Form
    {
        private string id { get; set; }
        public UpdateCabinet(DataRow cabinet)
        {
            InitializeComponent();
            cabinetCPBox.Text = cabinet["code_postal"].ToString();
            cabinetAdresseBox.Text = cabinet["adresse"].ToString();
            cabinetVillebox.Text = cabinet["ville"].ToString();
            id = cabinet["id"].ToString();
        }

        private void validerbutton_Click(object sender, EventArgs e)
        {
            var geocoder = new Geocoder("AIzaSyDoOuaAcFk-apUd7qNPaVnJcPV7a8iUTn0");
            var locations = geocoder.Geocode(cabinetAdresseBox.Text);
            string lat = locations.First().LatLng.Latitude.ToString();
            string lon = locations.First().LatLng.Longitude.ToString();
            string adresse = locations.First().LocationName.ToString().Split(',').First();
            BddRequest updateCabinet = new BddRequest();
            string request = "UPDATE cabinet set adresse= \"" + adresse + "\",code_postal= '" + cabinetCPBox.Text + "',ville=\"" + cabinetVillebox.Text + "\",longitude=\""+lon+"\",latitude=\""+lat+"\" where id = " + id;
            updateCabinet.DataRequest(request);
            MessageBox.Show("Vos informations ont été enregistrées avec succès");
            utilisateurAccueil accueil = Application.OpenForms["utilisateurAccueil"] as utilisateurAccueil;
            utilisateurAccueil newaccueil = new utilisateurAccueil();
            var upt = this;
            accueil.willCloseduti = false;
            accueil.Close();
            newaccueil.Show();
            upt.Close();
        }
    }
}
