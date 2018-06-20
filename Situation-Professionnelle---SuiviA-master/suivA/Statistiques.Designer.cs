namespace suivA
{
    partial class Statistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistiques));
            this.titleLabel = new System.Windows.Forms.Label();
            this.statMedecinLabel = new System.Windows.Forms.Label();
            this.medecinBox = new System.Windows.Forms.ComboBox();
            this.fPPicker = new System.Windows.Forms.DateTimePicker();
            this.dPPicker = new System.Windows.Forms.DateTimePicker();
            this.medecinLabel = new System.Windows.Forms.Label();
            this.pDebutLabel = new System.Windows.Forms.Label();
            this.pFinLabel = new System.Windows.Forms.Label();
            this.statMedecinResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visiteurLabel = new System.Windows.Forms.Label();
            this.visiteurBox = new System.Windows.Forms.ComboBox();
            this.labelJour = new System.Windows.Forms.Label();
            this.dVisiteVis = new System.Windows.Forms.DateTimePicker();
            this.statVisiteurJourResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statVisiteurHeurePResultLabel = new System.Windows.Forms.Label();
            this.resultTpsAttenteLabel = new System.Windows.Forms.Label();
            this.tpsAttenteLabel = new System.Windows.Forms.Label();
            this.resultTempsEntretienLabel = new System.Windows.Forms.Label();
            this.tpsEntretienLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Blue;
            this.titleLabel.Location = new System.Drawing.Point(16, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(217, 51);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Statistiques";
            // 
            // statMedecinLabel
            // 
            this.statMedecinLabel.AutoSize = true;
            this.statMedecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.statMedecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMedecinLabel.Location = new System.Drawing.Point(17, 124);
            this.statMedecinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statMedecinLabel.Name = "statMedecinLabel";
            this.statMedecinLabel.Size = new System.Drawing.Size(636, 41);
            this.statMedecinLabel.TabIndex = 24;
            this.statMedecinLabel.Text = "Nombre de visites par médecin par période :";
            // 
            // medecinBox
            // 
            this.medecinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medecinBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinBox.FormattingEnabled = true;
            this.medecinBox.Location = new System.Drawing.Point(188, 204);
            this.medecinBox.Margin = new System.Windows.Forms.Padding(4);
            this.medecinBox.Name = "medecinBox";
            this.medecinBox.Size = new System.Drawing.Size(279, 48);
            this.medecinBox.TabIndex = 25;
            this.medecinBox.SelectedIndexChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // fPPicker
            // 
            this.fPPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPPicker.CustomFormat = "dd/MM/yyyy";
            this.fPPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fPPicker.Location = new System.Drawing.Point(888, 206);
            this.fPPicker.Margin = new System.Windows.Forms.Padding(4);
            this.fPPicker.Name = "fPPicker";
            this.fPPicker.Size = new System.Drawing.Size(205, 49);
            this.fPPicker.TabIndex = 26;
            this.fPPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.fPPicker.ValueChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // dPPicker
            // 
            this.dPPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPPicker.CustomFormat = "dd/MM/yyyy";
            this.dPPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPPicker.Location = new System.Drawing.Point(593, 206);
            this.dPPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dPPicker.Name = "dPPicker";
            this.dPPicker.Size = new System.Drawing.Size(205, 49);
            this.dPPicker.TabIndex = 27;
            this.dPPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dPPicker.ValueChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // medecinLabel
            // 
            this.medecinLabel.AutoSize = true;
            this.medecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.medecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinLabel.Location = new System.Drawing.Point(17, 204);
            this.medecinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medecinLabel.Name = "medecinLabel";
            this.medecinLabel.Size = new System.Drawing.Size(139, 41);
            this.medecinLabel.TabIndex = 28;
            this.medecinLabel.Text = "Médecin";
            // 
            // pDebutLabel
            // 
            this.pDebutLabel.AutoSize = true;
            this.pDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.pDebutLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDebutLabel.Location = new System.Drawing.Point(476, 204);
            this.pDebutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pDebutLabel.Name = "pDebutLabel";
            this.pDebutLabel.Size = new System.Drawing.Size(103, 41);
            this.pDebutLabel.TabIndex = 29;
            this.pDebutLabel.Text = "Début";
            // 
            // pFinLabel
            // 
            this.pFinLabel.AutoSize = true;
            this.pFinLabel.BackColor = System.Drawing.Color.Transparent;
            this.pFinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFinLabel.Location = new System.Drawing.Point(817, 208);
            this.pFinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pFinLabel.Name = "pFinLabel";
            this.pFinLabel.Size = new System.Drawing.Size(60, 41);
            this.pFinLabel.TabIndex = 30;
            this.pFinLabel.Text = "Fin";
            // 
            // statMedecinResultLabel
            // 
            this.statMedecinResultLabel.AutoSize = true;
            this.statMedecinResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statMedecinResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMedecinResultLabel.Location = new System.Drawing.Point(708, 124);
            this.statMedecinResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statMedecinResultLabel.Name = "statMedecinResultLabel";
            this.statMedecinResultLabel.Size = new System.Drawing.Size(0, 41);
            this.statMedecinResultLabel.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre de visites par visiteur par jour :";
            // 
            // visiteurLabel
            // 
            this.visiteurLabel.AutoSize = true;
            this.visiteurLabel.BackColor = System.Drawing.Color.Transparent;
            this.visiteurLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteurLabel.Location = new System.Drawing.Point(17, 524);
            this.visiteurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visiteurLabel.Name = "visiteurLabel";
            this.visiteurLabel.Size = new System.Drawing.Size(124, 41);
            this.visiteurLabel.TabIndex = 33;
            this.visiteurLabel.Text = "Visiteur";
            // 
            // visiteurBox
            // 
            this.visiteurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visiteurBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteurBox.FormattingEnabled = true;
            this.visiteurBox.Location = new System.Drawing.Point(188, 524);
            this.visiteurBox.Margin = new System.Windows.Forms.Padding(4);
            this.visiteurBox.Name = "visiteurBox";
            this.visiteurBox.Size = new System.Drawing.Size(279, 48);
            this.visiteurBox.TabIndex = 34;
            this.visiteurBox.SelectedIndexChanged += new System.EventHandler(this.paramChangeVisiteur);
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.BackColor = System.Drawing.Color.Transparent;
            this.labelJour.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(476, 524);
            this.labelJour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(77, 41);
            this.labelJour.TabIndex = 35;
            this.labelJour.Text = "Jour";
            // 
            // dVisiteVis
            // 
            this.dVisiteVis.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteVis.CustomFormat = "dd/MM/yyyy";
            this.dVisiteVis.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteVis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dVisiteVis.Location = new System.Drawing.Point(593, 524);
            this.dVisiteVis.Margin = new System.Windows.Forms.Padding(4);
            this.dVisiteVis.Name = "dVisiteVis";
            this.dVisiteVis.Size = new System.Drawing.Size(205, 49);
            this.dVisiteVis.TabIndex = 36;
            this.dVisiteVis.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dVisiteVis.ValueChanged += new System.EventHandler(this.paramChangeVisiteur);
            // 
            // statVisiteurJourResultLabel
            // 
            this.statVisiteurJourResultLabel.AutoSize = true;
            this.statVisiteurJourResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statVisiteurJourResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statVisiteurJourResultLabel.Location = new System.Drawing.Point(628, 330);
            this.statVisiteurJourResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statVisiteurJourResultLabel.Name = "statVisiteurJourResultLabel";
            this.statVisiteurJourResultLabel.Size = new System.Drawing.Size(0, 41);
            this.statVisiteurJourResultLabel.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(675, 41);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre d\'heures passées par visiteur par jour :";
            // 
            // statVisiteurHeurePResultLabel
            // 
            this.statVisiteurHeurePResultLabel.AutoSize = true;
            this.statVisiteurHeurePResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statVisiteurHeurePResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statVisiteurHeurePResultLabel.Location = new System.Drawing.Point(729, 402);
            this.statVisiteurHeurePResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statVisiteurHeurePResultLabel.Name = "statVisiteurHeurePResultLabel";
            this.statVisiteurHeurePResultLabel.Size = new System.Drawing.Size(0, 41);
            this.statVisiteurHeurePResultLabel.TabIndex = 40;
            // 
            // resultTpsAttenteLabel
            // 
            this.resultTpsAttenteLabel.AutoSize = true;
            this.resultTpsAttenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultTpsAttenteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTpsAttenteLabel.Location = new System.Drawing.Point(388, 773);
            this.resultTpsAttenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultTpsAttenteLabel.Name = "resultTpsAttenteLabel";
            this.resultTpsAttenteLabel.Size = new System.Drawing.Size(0, 41);
            this.resultTpsAttenteLabel.TabIndex = 42;
            // 
            // tpsAttenteLabel
            // 
            this.tpsAttenteLabel.AutoSize = true;
            this.tpsAttenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.tpsAttenteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsAttenteLabel.Location = new System.Drawing.Point(17, 773);
            this.tpsAttenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tpsAttenteLabel.Name = "tpsAttenteLabel";
            this.tpsAttenteLabel.Size = new System.Drawing.Size(345, 41);
            this.tpsAttenteLabel.TabIndex = 41;
            this.tpsAttenteLabel.Text = "Temps d\'attente moyen";
            // 
            // resultTempsEntretienLabel
            // 
            this.resultTempsEntretienLabel.AutoSize = true;
            this.resultTempsEntretienLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultTempsEntretienLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTempsEntretienLabel.Location = new System.Drawing.Point(461, 714);
            this.resultTempsEntretienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultTempsEntretienLabel.Name = "resultTempsEntretienLabel";
            this.resultTempsEntretienLabel.Size = new System.Drawing.Size(0, 41);
            this.resultTempsEntretienLabel.TabIndex = 44;
            // 
            // tpsEntretienLabel
            // 
            this.tpsEntretienLabel.AutoSize = true;
            this.tpsEntretienLabel.BackColor = System.Drawing.Color.Transparent;
            this.tpsEntretienLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsEntretienLabel.Location = new System.Drawing.Point(17, 714);
            this.tpsEntretienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tpsEntretienLabel.Name = "tpsEntretienLabel";
            this.tpsEntretienLabel.Size = new System.Drawing.Size(417, 41);
            this.tpsEntretienLabel.TabIndex = 43;
            this.tpsEntretienLabel.Text = "Temps moyen d\'un entretien";
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1256, 828);
            this.Controls.Add(this.resultTempsEntretienLabel);
            this.Controls.Add(this.tpsEntretienLabel);
            this.Controls.Add(this.resultTpsAttenteLabel);
            this.Controls.Add(this.tpsAttenteLabel);
            this.Controls.Add(this.statVisiteurHeurePResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statVisiteurJourResultLabel);
            this.Controls.Add(this.dVisiteVis);
            this.Controls.Add(this.labelJour);
            this.Controls.Add(this.visiteurBox);
            this.Controls.Add(this.visiteurLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statMedecinResultLabel);
            this.Controls.Add(this.pFinLabel);
            this.Controls.Add(this.pDebutLabel);
            this.Controls.Add(this.medecinLabel);
            this.Controls.Add(this.dPPicker);
            this.Controls.Add(this.fPPicker);
            this.Controls.Add(this.medecinBox);
            this.Controls.Add(this.statMedecinLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1274, 875);
            this.MinimumSize = new System.Drawing.Size(1274, 875);
            this.Name = "Statistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label statMedecinLabel;
        private System.Windows.Forms.ComboBox medecinBox;
        private System.Windows.Forms.DateTimePicker fPPicker;
        private System.Windows.Forms.DateTimePicker dPPicker;
        private System.Windows.Forms.Label medecinLabel;
        private System.Windows.Forms.Label pDebutLabel;
        private System.Windows.Forms.Label pFinLabel;
        private System.Windows.Forms.Label statMedecinResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label visiteurLabel;
        private System.Windows.Forms.ComboBox visiteurBox;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.DateTimePicker dVisiteVis;
        private System.Windows.Forms.Label statVisiteurJourResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statVisiteurHeurePResultLabel;
        private System.Windows.Forms.Label resultTpsAttenteLabel;
        private System.Windows.Forms.Label tpsAttenteLabel;
        private System.Windows.Forms.Label resultTempsEntretienLabel;
        private System.Windows.Forms.Label tpsEntretienLabel;
    }
}