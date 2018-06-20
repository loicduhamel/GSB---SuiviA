using System;
using System.Data;
namespace suivA
{
    partial class visiteurAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visiteurAccueil));
            this.navPanel = new System.Windows.Forms.Panel();
            this.getStat = new System.Windows.Forms.Label();
            this.pipe = new System.Windows.Forms.Label();
            this.addVisite = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lineTitleLabel3 = new System.Windows.Forms.Label();
            this.nomMedecinTitleLabel = new System.Windows.Forms.Label();
            this.hDebutTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel1 = new System.Windows.Forms.Label();
            this.adresseTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel2 = new System.Windows.Forms.Label();
            this.dVisiteTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel4 = new System.Windows.Forms.Label();
            this.rdvTitleLabel = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.Blue;
            this.navPanel.Controls.Add(this.getStat);
            this.navPanel.Controls.Add(this.pipe);
            this.navPanel.Controls.Add(this.addVisite);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1185, 50);
            this.navPanel.TabIndex = 0;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navPanel_Paint);
            // 
            // getStat
            // 
            this.getStat.AutoSize = true;
            this.getStat.BackColor = System.Drawing.Color.Transparent;
            this.getStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getStat.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStat.ForeColor = System.Drawing.Color.White;
            this.getStat.Location = new System.Drawing.Point(210, 9);
            this.getStat.Name = "getStat";
            this.getStat.Size = new System.Drawing.Size(178, 41);
            this.getStat.TabIndex = 1;
            this.getStat.Text = "Statistiques";
            this.getStat.Click += new System.EventHandler(this.getStat_Click);
            // 
            // pipe
            // 
            this.pipe.AutoSize = true;
            this.pipe.BackColor = System.Drawing.Color.Transparent;
            this.pipe.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipe.ForeColor = System.Drawing.Color.White;
            this.pipe.Location = new System.Drawing.Point(177, 9);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(34, 41);
            this.pipe.TabIndex = 1;
            this.pipe.Text = "|";
            // 
            // addVisite
            // 
            this.addVisite.AutoSize = true;
            this.addVisite.BackColor = System.Drawing.Color.Transparent;
            this.addVisite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVisite.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVisite.ForeColor = System.Drawing.Color.White;
            this.addVisite.Location = new System.Drawing.Point(12, 9);
            this.addVisite.Name = "addVisite";
            this.addVisite.Size = new System.Drawing.Size(202, 41);
            this.addVisite.TabIndex = 0;
            this.addVisite.Text = "Ajouter visite";
            this.addVisite.Click += new System.EventHandler(this.addVisite_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(60, 263);
            this.panel1.MaximumSize = new System.Drawing.Size(1040, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.lineTitleLabel3);
            this.panel2.Controls.Add(this.nomMedecinTitleLabel);
            this.panel2.Controls.Add(this.hDebutTitleLabel);
            this.panel2.Controls.Add(this.lineTitleLabel1);
            this.panel2.Controls.Add(this.adresseTitleLabel);
            this.panel2.Controls.Add(this.lineTitleLabel2);
            this.panel2.Controls.Add(this.dVisiteTitleLabel);
            this.panel2.Controls.Add(this.lineTitleLabel4);
            this.panel2.Controls.Add(this.rdvTitleLabel);
            this.panel2.Location = new System.Drawing.Point(60, 206);
            this.panel2.MaximumSize = new System.Drawing.Size(1040, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 59);
            this.panel2.TabIndex = 3;
            // 
            // lineTitleLabel3
            // 
            this.lineTitleLabel3.AutoSize = true;
            this.lineTitleLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel3.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel3.Location = new System.Drawing.Point(541, 9);
            this.lineTitleLabel3.Name = "lineTitleLabel3";
            this.lineTitleLabel3.Size = new System.Drawing.Size(26, 31);
            this.lineTitleLabel3.TabIndex = 5;
            this.lineTitleLabel3.Text = "|";
            // 
            // nomMedecinTitleLabel
            // 
            this.nomMedecinTitleLabel.AutoSize = true;
            this.nomMedecinTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomMedecinTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMedecinTitleLabel.ForeColor = System.Drawing.Color.White;
            this.nomMedecinTitleLabel.Location = new System.Drawing.Point(253, 9);
            this.nomMedecinTitleLabel.Name = "nomMedecinTitleLabel";
            this.nomMedecinTitleLabel.Size = new System.Drawing.Size(102, 31);
            this.nomMedecinTitleLabel.TabIndex = 1;
            this.nomMedecinTitleLabel.Text = "Médecin";
            this.nomMedecinTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hDebutTitleLabel
            // 
            this.hDebutTitleLabel.AutoSize = true;
            this.hDebutTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.hDebutTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutTitleLabel.ForeColor = System.Drawing.Color.White;
            this.hDebutTitleLabel.Location = new System.Drawing.Point(575, 9);
            this.hDebutTitleLabel.Name = "hDebutTitleLabel";
            this.hDebutTitleLabel.Size = new System.Drawing.Size(141, 31);
            this.hDebutTitleLabel.TabIndex = 4;
            this.hDebutTitleLabel.Text = "Heure début";
            this.hDebutTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineTitleLabel1
            // 
            this.lineTitleLabel1.AutoSize = true;
            this.lineTitleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel1.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel1.Location = new System.Drawing.Point(219, 9);
            this.lineTitleLabel1.Name = "lineTitleLabel1";
            this.lineTitleLabel1.Size = new System.Drawing.Size(26, 31);
            this.lineTitleLabel1.TabIndex = 1;
            this.lineTitleLabel1.Text = "|";
            // 
            // adresseTitleLabel
            // 
            this.adresseTitleLabel.AutoSize = true;
            this.adresseTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.adresseTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseTitleLabel.ForeColor = System.Drawing.Color.White;
            this.adresseTitleLabel.Location = new System.Drawing.Point(81, 9);
            this.adresseTitleLabel.Name = "adresseTitleLabel";
            this.adresseTitleLabel.Size = new System.Drawing.Size(91, 31);
            this.adresseTitleLabel.TabIndex = 0;
            this.adresseTitleLabel.Text = "Cabinet";
            this.adresseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineTitleLabel2
            // 
            this.lineTitleLabel2.AutoSize = true;
            this.lineTitleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel2.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel2.Location = new System.Drawing.Point(360, 9);
            this.lineTitleLabel2.Name = "lineTitleLabel2";
            this.lineTitleLabel2.Size = new System.Drawing.Size(26, 31);
            this.lineTitleLabel2.TabIndex = 1;
            this.lineTitleLabel2.Text = "|";
            // 
            // dVisiteTitleLabel
            // 
            this.dVisiteTitleLabel.AutoSize = true;
            this.dVisiteTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.dVisiteTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteTitleLabel.ForeColor = System.Drawing.Color.White;
            this.dVisiteTitleLabel.Location = new System.Drawing.Point(394, 9);
            this.dVisiteTitleLabel.Name = "dVisiteTitleLabel";
            this.dVisiteTitleLabel.Size = new System.Drawing.Size(175, 31);
            this.dVisiteTitleLabel.TabIndex = 0;
            this.dVisiteTitleLabel.Text = "Date de la visite";
            this.dVisiteTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineTitleLabel4
            // 
            this.lineTitleLabel4.AutoSize = true;
            this.lineTitleLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel4.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel4.Location = new System.Drawing.Point(700, 9);
            this.lineTitleLabel4.Name = "lineTitleLabel4";
            this.lineTitleLabel4.Size = new System.Drawing.Size(26, 31);
            this.lineTitleLabel4.TabIndex = 1;
            this.lineTitleLabel4.Text = "|";
            // 
            // rdvTitleLabel
            // 
            this.rdvTitleLabel.AutoSize = true;
            this.rdvTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvTitleLabel.ForeColor = System.Drawing.Color.White;
            this.rdvTitleLabel.Location = new System.Drawing.Point(736, 9);
            this.rdvTitleLabel.Name = "rdvTitleLabel";
            this.rdvTitleLabel.Size = new System.Drawing.Size(202, 31);
            this.rdvTitleLabel.TabIndex = 0;
            this.rdvTitleLabel.Text = "Sur Rendez-Vous ?";
            this.rdvTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visiteurAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "visiteurAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visiteurAccueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.visiteurAccueil_FormClosing);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private void SetForm(int i, int y, DataRow visite)
        {
            this.nomMedecinLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.lineLabel1 = new System.Windows.Forms.Label();
            this.lineLabel2 = new System.Windows.Forms.Label();
            this.dVisiteLabel = new System.Windows.Forms.Label();
            this.lineLabel3 = new System.Windows.Forms.Label();
            this.hDebutLabel = new System.Windows.Forms.Label();
            this.lineLabel4 = new System.Windows.Forms.Label();
            this.rdvLabel = new System.Windows.Forms.Label();
            this.editPicture = new System.Windows.Forms.PictureBox();
            this.deletePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).BeginInit();
            //
            //nomMedecinLabel
            //
            this.nomMedecinLabel.AutoSize = true;
            this.nomMedecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomMedecinLabel.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMedecinLabel.ForeColor = System.Drawing.Color.White;
            this.nomMedecinLabel.Location = new System.Drawing.Point(253, 9 + y);
            this.nomMedecinLabel.Name = "nomMedecinLabel" + i;
            this.nomMedecinLabel.Size = new System.Drawing.Size(100, 33);
            this.nomMedecinLabel.TabIndex = 1;
            this.nomMedecinLabel.Text = visite["nom"].ToString();
            this.nomMedecinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.BackColor = System.Drawing.Color.Transparent;
            this.adresseLabel.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLabel.ForeColor = System.Drawing.Color.White;
            this.adresseLabel.Location = new System.Drawing.Point(12, 9 + y);
            this.adresseLabel.Name = "adresseLabel" + i;
            this.adresseLabel.Size = new System.Drawing.Size(200, 33);
            this.adresseLabel.TabIndex = 0;
            this.adresseLabel.Text = visite["adresse"].ToString();
            this.adresseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineLabel1
            // 
            this.lineLabel1.AutoSize = true;
            this.lineLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel1.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel1.ForeColor = System.Drawing.Color.White;
            this.lineLabel1.Location = new System.Drawing.Point(219, 9 + y);
            this.lineLabel1.Name = "lineLabel" + i;
            this.lineLabel1.Size = new System.Drawing.Size(27, 33);
            this.lineLabel1.TabIndex = 1;
            this.lineLabel1.Text = "|";
            // 
            // lineLabel2
            // 
            this.lineLabel2.AutoSize = true;
            this.lineLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel2.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel2.ForeColor = System.Drawing.Color.White;
            this.lineLabel2.Location = new System.Drawing.Point(360, 9 + y);
            this.lineLabel2.Name = "lineLabel2" + i;
            this.lineLabel2.Size = new System.Drawing.Size(27, 33);
            this.lineLabel2.TabIndex = 1;
            this.lineLabel2.Text = "|";
            // 
            // dVisiteLabel
            // 
            this.dVisiteLabel.AutoSize = true;
            this.dVisiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.dVisiteLabel.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteLabel.ForeColor = System.Drawing.Color.White;
            this.dVisiteLabel.Location = new System.Drawing.Point(394, 9 + y);
            this.dVisiteLabel.Name = "adresseLabel" + i;
            this.dVisiteLabel.Size = new System.Drawing.Size(100, 33);
            this.dVisiteLabel.TabIndex = 0;
            this.dVisiteLabel.Text = visite["date_visite"].ToString();
            this.dVisiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineLabel3
            // 
            this.lineLabel3.AutoSize = true;
            this.lineLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel3.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel3.ForeColor = System.Drawing.Color.White;
            this.lineLabel3.Location = new System.Drawing.Point(541, 9 + y);
            this.lineLabel3.Name = "lineLabel3" + i;
            this.lineLabel3.Size = new System.Drawing.Size(27, 33);
            this.lineLabel3.TabIndex = 5;
            this.lineLabel3.Text = "|";
            // 
            // hDebutLabel
            // 
            this.hDebutLabel.AutoSize = true;
            this.hDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.hDebutLabel.Font = new System.Drawing.Font("Calibri",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutLabel.ForeColor = System.Drawing.Color.White;
            this.hDebutLabel.Location = new System.Drawing.Point(575, 9 + y);
            this.hDebutLabel.Name = "hDebutLabel" + i;
            this.hDebutLabel.Size = new System.Drawing.Size(140, 33);
            this.hDebutLabel.TabIndex = 4;
            this.hDebutLabel.Text = visite["heure_debut_entretien"].ToString(); ;
            this.hDebutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editPicture
            // 
            this.editPicture.BackColor = System.Drawing.Color.Transparent;
            this.editPicture.Image = ((System.Drawing.Image)(Properties.Resources.editPicture));
            this.editPicture.Location = new System.Drawing.Point(900, 8 + y);
            this.editPicture.Name = "editPicture" + i;
            this.editPicture.Size = new System.Drawing.Size(24, 24);
            this.editPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPicture.TabIndex = 4;
            this.editPicture.TabStop = false;
            this.editPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPicture.Click += new System.EventHandler(delegate (object sender, EventArgs e)
            {
                updateVisite(sender, e, visite);
            });
            // 
            // lineLabel4
            // 
            this.lineLabel4.AutoSize = true;
            this.lineLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel4.ForeColor = System.Drawing.Color.White;
            this.lineLabel4.Location = new System.Drawing.Point(700, 9 + y);
            this.lineLabel4.Name = "lineTitleLabel3" + i;
            this.lineLabel4.Size = new System.Drawing.Size(27, 33);
            this.lineLabel4.TabIndex = 1;
            this.lineLabel4.Text = "|";
            // 
            // rdvLabel
            // 
            this.rdvLabel.AutoSize = true;
            this.rdvLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvLabel.ForeColor = System.Drawing.Color.White;
            this.rdvLabel.Location = new System.Drawing.Point(780, 9 + y);
            this.rdvLabel.Name = "rdvLabel" + i;
            this.rdvLabel.Size = new System.Drawing.Size(100, 33);
            this.rdvLabel.TabIndex = 0;
            this.rdvLabel.Text = visite["rdv"].ToString();
            this.rdvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletePicture
            // 
            this.deletePicture.BackColor = System.Drawing.Color.Transparent;
            this.deletePicture.Image = ((System.Drawing.Image)(Properties.Resources.deletePicture));
            this.deletePicture.Location = new System.Drawing.Point(950, 8 + y);
            this.deletePicture.Name = "deletePicture" + i;
            this.deletePicture.Size = new System.Drawing.Size(24, 24);
            this.deletePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePicture.TabIndex = 4;
            this.deletePicture.TabStop = false;
            this.deletePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePicture.Click += new System.EventHandler(delegate (object sender, EventArgs e)
            {
                deleteVisite(sender, e, visite);
            });

            panel1.Size = new System.Drawing.Size(1040, 100 * i);
            panel1.Controls.Add(this.nomMedecinLabel);
            panel1.Controls.Add(this.lineLabel1);
            panel1.Controls.Add(this.adresseLabel);
            panel1.Controls.Add(this.lineLabel2);
            panel1.Controls.Add(this.dVisiteLabel);
            panel1.Controls.Add(this.lineLabel3);
            panel1.Controls.Add(this.hDebutLabel);
            panel1.Controls.Add(this.lineLabel4);
            panel1.Controls.Add(this.rdvLabel);
            panel1.Controls.Add(this.editPicture);
            panel1.Controls.Add(this.deletePicture);

            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).EndInit();
        }

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label addVisite;
        private System.Windows.Forms.Label getStat;
        private System.Windows.Forms.Label pipe;
        private System.Windows.Forms.Label nomMedecinLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label lineLabel1;
        private System.Windows.Forms.Label lineLabel2;
        private System.Windows.Forms.Label dVisiteLabel;
        private System.Windows.Forms.Label nomMedecinTitleLabel;
        private System.Windows.Forms.Label adresseTitleLabel;
        private System.Windows.Forms.Label lineTitleLabel1;
        private System.Windows.Forms.Label lineTitleLabel2;
        private System.Windows.Forms.Label dVisiteTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lineTitleLabel3;
        private System.Windows.Forms.Label hDebutTitleLabel;
        private System.Windows.Forms.Label lineLabel3;
        private System.Windows.Forms.Label hDebutLabel;
        private System.Windows.Forms.PictureBox editPicture;
        private System.Windows.Forms.PictureBox deletePicture;
        private System.Windows.Forms.Label rdvTitleLabel;
        private System.Windows.Forms.Label lineTitleLabel4;
        private System.Windows.Forms.Label rdvLabel;
        private System.Windows.Forms.Label lineLabel4;
    }
}