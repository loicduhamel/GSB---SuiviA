using System;
using System.Windows.Forms;

namespace suivA
{
    public partial class AddVisite : Form
    {
        public Visiteur visiteurData { get; set; }

        // Constructeur d'ajout de visite
        public AddVisite(Visiteur visiteur)
        {
            InitializeComponent();
            medecinSelect.Text = visiteur.medecin_name + ", " + visiteur.medecin_surname;
            cabinetSelect.Text = visiteur.medecin_cabinet;
            visiteurData = visiteur;
        }

        // Ajout de visite détaillé dans la BDD
        private void validerbutton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            bool rdv;
            if(hArriveePicker.Text == "00:00")
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
            if(radioRdvTrue.Checked == false && radioRdvFalse.Checked == false)
            {
                isValid = false;
                MessageBox.Show("Veuillez cocher le type de visite");
            }
            if(isValid == true)
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
                string request = "INSERT INTO visite (rendez_vous, heure_arrivee, heure_debut_entretien, heure_depart, date_visite, id_medecin, id_utilisateur) VALUES ("+ rdv +", '"+ hArriveePicker.Text +"', '"+ hDebutPicker.Text +"', '"+ hDepartPicker.Text +"', '"+ visiteDatePicker.Text +"', "+ visiteurData.id_medecin  +", "+ visiteurData.id +");";
                addVisite.DataRequest(request);
                MessageBox.Show("Vos informations ont été enregistrées avec succès");
                visiteurAccueil accueil = Application.OpenForms["visiteurAccueil"] as visiteurAccueil;
                visiteurAccueil newaccueil = new visiteurAccueil(visiteurData.id);
                var upt = this;
                accueil.willClosed = false;
                accueil.Close();
                newaccueil.Show();
                upt.Close();
            }
        }
    }
}
