namespace suivA
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.validerbutton = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.identifiantbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.identifiantlabel = new System.Windows.Forms.Label();
            this.gsbPicture = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelLogin.Controls.Add(this.validerbutton);
            this.panelLogin.Controls.Add(this.passwordbox);
            this.panelLogin.Controls.Add(this.identifiantbox);
            this.panelLogin.Controls.Add(this.passwordlabel);
            this.panelLogin.Controls.Add(this.identifiantlabel);
            this.panelLogin.Controls.Add(this.gsbPicture);
            this.panelLogin.Location = new System.Drawing.Point(350, 172);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(700, 692);
            this.panelLogin.TabIndex = 15;
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.White;
            this.validerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(286, 577);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(128, 46);
            this.validerbutton.TabIndex = 19;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(338, 471);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(325, 48);
            this.passwordbox.TabIndex = 18;
            this.passwordbox.UseSystemPasswordChar = true;
            this.passwordbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordbox_KeyDown);
            // 
            // identifiantbox
            // 
            this.identifiantbox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantbox.Location = new System.Drawing.Point(338, 369);
            this.identifiantbox.Name = "identifiantbox";
            this.identifiantbox.Size = new System.Drawing.Size(325, 48);
            this.identifiantbox.TabIndex = 17;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(63, 471);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(204, 41);
            this.passwordlabel.TabIndex = 16;
            this.passwordlabel.Text = "Mot de passe";
            // 
            // identifiantlabel
            // 
            this.identifiantlabel.AutoSize = true;
            this.identifiantlabel.BackColor = System.Drawing.Color.Transparent;
            this.identifiantlabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantlabel.Location = new System.Drawing.Point(63, 369);
            this.identifiantlabel.Name = "identifiantlabel";
            this.identifiantlabel.Size = new System.Drawing.Size(162, 41);
            this.identifiantlabel.TabIndex = 15;
            this.identifiantlabel.Text = "Identifiant";
            // 
            // gsbPicture
            // 
            this.gsbPicture.BackColor = System.Drawing.Color.Transparent;
            this.gsbPicture.Image = ((System.Drawing.Image)(resources.GetObject("gsbPicture.Image")));
            this.gsbPicture.Location = new System.Drawing.Point(128, 0);
            this.gsbPicture.Name = "gsbPicture";
            this.gsbPicture.Size = new System.Drawing.Size(443, 294);
            this.gsbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gsbPicture.TabIndex = 20;
            this.gsbPicture.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1379, 985);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1397, 1032);
            this.MinimumSize = new System.Drawing.Size(1397, 1028);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox identifiantbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label identifiantlabel;
        private System.Windows.Forms.PictureBox gsbPicture;
    }
}

