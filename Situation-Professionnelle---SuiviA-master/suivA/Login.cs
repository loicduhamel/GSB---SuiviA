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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // Fonction qui compare la saisie lors du login/mdp a ceux de la BDD
        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest loginRequest = new BddRequest();
            bool verif = loginRequest.ActiveDirectoryConnexion(identifiantbox.Text, passwordbox.Text);
            if (verif)
            {
                string result = loginRequest.loginRequest(identifiantbox.Text);
                var loginWindow = this;
                Visiteur visiteur = loginRequest.getVisiteur(result);
                if(visiteur.id_role.ToString() == "3")
                {
                    visiteurAccueil gotoAccueilVisi = new visiteurAccueil(result);
                    gotoAccueilVisi.Show();
                }
                else
                {
                    utilisateurAccueil gotoAccueilUti = new utilisateurAccueil();
                    gotoAccueilUti.Show();
                }
                loginWindow.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe ou identifiant incorrect");
                identifiantbox.Text = null;
                passwordbox.Text = null;
            }
        }

        // Fonction qui permet d'appuyer sur entrée au lieu du bouton validé
        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)

            {
                validerbutton_Click(sender, e);
            }
        }
    }
}
