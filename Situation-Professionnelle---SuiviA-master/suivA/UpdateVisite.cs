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
    public partial class UpdateVisite : Form
    {
        private string id { get; set; }
        private string id_utilisateur { get; set; }
        // Constructeur de modification des visite
        public UpdateVisite(DataRow visite,Visiteur visiteurData)
        {
            InitializeComponent();
            medecinSelect.Text = visiteurData.medecin_name + ", " + visiteurData.medecin_surname;
            cabinetSelect.Text = visiteurData.medecin_cabinet;
            hArriveePicker.Text = visite["heure_arrivee"].ToString();
            hDepartPicker.Text = visite["heure_depart"].ToString();
            hDebutPicker.Text = visite["heure_debut_entretien"].ToString();
            visiteDatePicker.Text = visite["date_visite"].ToString();
            if (visite["rendez_vous"].ToString() == "True"){
                radioRdvTrue.Checked = true;
            }
            else{
                radioRdvFalse.Checked = true;
            }
            id = visite["id"].ToString();
            id_utilisateur = visite["id_utilisateur"].ToString();
        }

        //Fonctions qui valide la modification des visites
        private void validerbutton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            bool rdv;
            if (hArriveePicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure d'arrivée");
            }
            if (hDebutPicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure de début");
            }
            if (hDepartPicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure de fin");
            }
            if (radioRdvTrue.Checked == false && radioRdvFalse.Checked == false)
            {
                isValid = false;
                MessageBox.Show("Veuillez cocher le type de visite");
            }
            if (isValid == true)
            {
                if (radioRdvTrue.Checked == true)
                {
                    rdv = true;
                }
                else
                {
                    rdv = false;
                }
                BddRequest addVisite = new BddRequest();
                string request = "UPDATE visite set rendez_vous= " + rdv + ",heure_arrivee= '" + hArriveePicker.Text + "',heure_debut_entretien='" + hDebutPicker.Text + "', heure_depart='" + hDepartPicker.Text + "', date_visite='" + visiteDatePicker.Text + "' where id="+id;
                addVisite.DataRequest(request);
                MessageBox.Show("Vos informations ont été enregistrées avec succès");
                visiteurAccueil accueil = Application.OpenForms["visiteurAccueil"] as visiteurAccueil;
                visiteurAccueil newaccueil = new visiteurAccueil(id_utilisateur);
                var upt = this;
                accueil.willClosed = false;
                accueil.Close();
                newaccueil.Show();
                upt.Close();
            }
        }
    }
}
