using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivA
{
    // Class qui permet la modification des données sur un médecin
    public partial class UpdateMedecin : Form
    {
        private string id { get; set; }
        public UpdateMedecin(DataRow medecin)
        {
            InitializeComponent();
            nomBox.Text = medecin["nom"].ToString();
            prenomBox.Text = medecin["prenom"].ToString();
            BddRequest requestCabinet = new BddRequest();
            DataTable dtAdresse = requestCabinet.FillComboBox("Select adresse,id from cabinet");
            adresseBox.ValueMember = "id";
            adresseBox.DisplayMember = "adresse";
            adresseBox.DataSource = dtAdresse;
            int index = adresseBox.FindString(medecin["adresse"].ToString());
            adresseBox.SelectedIndex = index;
            id = medecin["id"].ToString();
        }

        // Fonction qui permet de valider la modification des données medecins.
        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest addVisite = new BddRequest();
            string request = "UPDATE medecin set nom= \"" + nomBox.Text + "\",prenom= '" + prenomBox.Text + "',id_cabinet=" + adresseBox.SelectedValue.ToString() + " where id = " + id;
            addVisite.DataRequest(request);
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
