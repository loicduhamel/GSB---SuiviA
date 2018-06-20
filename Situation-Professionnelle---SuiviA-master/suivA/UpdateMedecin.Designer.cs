namespace suivA
{
    partial class UpdateMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMedecin));
            this.medecinSelect = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.validerbutton = new System.Windows.Forms.Button();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.adresseBox = new System.Windows.Forms.ComboBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // medecinSelect
            // 
            this.medecinSelect.AutoSize = true;
            this.medecinSelect.BackColor = System.Drawing.Color.Transparent;
            this.medecinSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinSelect.Location = new System.Drawing.Point(175, 444);
            this.medecinSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medecinSelect.Name = "medecinSelect";
            this.medecinSelect.Size = new System.Drawing.Size(141, 41);
            this.medecinSelect.TabIndex = 60;
            this.medecinSelect.Text = "Cabinet :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Blue;
            this.titleLabel.Location = new System.Drawing.Point(24, 20);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(330, 51);
            this.titleLabel.TabIndex = 59;
            this.titleLabel.Text = "Modifier Médecin";
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.White;
            this.validerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(1065, 762);
            this.validerbutton.Margin = new System.Windows.Forms.Padding(4);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(171, 57);
            this.validerbutton.TabIndex = 58;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.Location = new System.Drawing.Point(175, 325);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(145, 41);
            this.prenomLabel.TabIndex = 45;
            this.prenomLabel.Text = "Prénom :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(175, 206);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(102, 41);
            this.nomLabel.TabIndex = 44;
            this.nomLabel.Text = "Nom :";
            // 
            // adresseBox
            // 
            this.adresseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adresseBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseBox.FormattingEnabled = true;
            this.adresseBox.Location = new System.Drawing.Point(393, 441);
            this.adresseBox.Margin = new System.Windows.Forms.Padding(4);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(471, 48);
            this.adresseBox.TabIndex = 61;
            // 
            // nomBox
            // 
            this.nomBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomBox.Location = new System.Drawing.Point(393, 197);
            this.nomBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(471, 49);
            this.nomBox.TabIndex = 62;
            // 
            // prenomBox
            // 
            this.prenomBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomBox.Location = new System.Drawing.Point(393, 316);
            this.prenomBox.Margin = new System.Windows.Forms.Padding(4);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(471, 49);
            this.prenomBox.TabIndex = 63;
            // 
            // UpdateMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1256, 828);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.medecinSelect);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1274, 875);
            this.MinimumSize = new System.Drawing.Size(1274, 875);
            this.Name = "UpdateMedecin";
            this.Text = "UpdateMedecin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medecinSelect;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.ComboBox adresseBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox prenomBox;
    }
}