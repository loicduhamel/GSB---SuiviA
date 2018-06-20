using System;

namespace suivA
{
    partial class UpdateVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVisite));
            this.visiteDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cabinetSelect = new System.Windows.Forms.Label();
            this.medecinSelect = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.validerbutton = new System.Windows.Forms.Button();
            this.hDepartPicker = new System.Windows.Forms.DateTimePicker();
            this.hDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.hArriveePicker = new System.Windows.Forms.DateTimePicker();
            this.radioRdvFalse = new System.Windows.Forms.RadioButton();
            this.radioRdvTrue = new System.Windows.Forms.RadioButton();
            this.rdvFalseLabel = new System.Windows.Forms.Label();
            this.rdvTrueLabel = new System.Windows.Forms.Label();
            this.rdvLabel = new System.Windows.Forms.Label();
            this.hDepart = new System.Windows.Forms.Label();
            this.hDebutLabel = new System.Windows.Forms.Label();
            this.hArriveeLabel = new System.Windows.Forms.Label();
            this.dvisiteLabel = new System.Windows.Forms.Label();
            this.medecinLabel = new System.Windows.Forms.Label();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visiteDatePicker
            // 
            this.visiteDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteDatePicker.CustomFormat = "yyyy-MM-dd";
            this.visiteDatePicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.visiteDatePicker.Location = new System.Drawing.Point(372, 334);
            this.visiteDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.visiteDatePicker.Name = "visiteDatePicker";
            this.visiteDatePicker.Size = new System.Drawing.Size(193, 49);
            this.visiteDatePicker.TabIndex = 43;
            this.visiteDatePicker.Value = new System.DateTime(2018, 4, 10, 10, 21, 9, 378);
            // 
            // cabinetSelect
            // 
            this.cabinetSelect.AutoSize = true;
            this.cabinetSelect.BackColor = System.Drawing.Color.Transparent;
            this.cabinetSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetSelect.Location = new System.Drawing.Point(284, 98);
            this.cabinetSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabinetSelect.Name = "cabinetSelect";
            this.cabinetSelect.Size = new System.Drawing.Size(124, 41);
            this.cabinetSelect.TabIndex = 42;
            this.cabinetSelect.Text = "Cabinet";
            // 
            // medecinSelect
            // 
            this.medecinSelect.AutoSize = true;
            this.medecinSelect.BackColor = System.Drawing.Color.Transparent;
            this.medecinSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinSelect.Location = new System.Drawing.Point(820, 98);
            this.medecinSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medecinSelect.Name = "medecinSelect";
            this.medecinSelect.Size = new System.Drawing.Size(139, 41);
            this.medecinSelect.TabIndex = 41;
            this.medecinSelect.Text = "Médecin";
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
            this.titleLabel.Size = new System.Drawing.Size(270, 51);
            this.titleLabel.TabIndex = 40;
            this.titleLabel.Text = "Modifier visite";
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
            this.validerbutton.TabIndex = 39;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // hDepartPicker
            // 
            this.hDepartPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepartPicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hDepartPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hDepartPicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hDepartPicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hDepartPicker.CustomFormat = "HH:mm";
            this.hDepartPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hDepartPicker.Location = new System.Drawing.Point(961, 522);
            this.hDepartPicker.Margin = new System.Windows.Forms.Padding(4);
            this.hDepartPicker.Name = "hDepartPicker";
            this.hDepartPicker.ShowUpDown = true;
            this.hDepartPicker.Size = new System.Drawing.Size(128, 49);
            this.hDepartPicker.TabIndex = 38;
            this.hDepartPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // hDebutPicker
            // 
            this.hDebutPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutPicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hDebutPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hDebutPicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hDebutPicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hDebutPicker.CustomFormat = "HH:mm";
            this.hDebutPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hDebutPicker.Location = new System.Drawing.Point(961, 426);
            this.hDebutPicker.Margin = new System.Windows.Forms.Padding(4);
            this.hDebutPicker.Name = "hDebutPicker";
            this.hDebutPicker.ShowUpDown = true;
            this.hDebutPicker.Size = new System.Drawing.Size(128, 49);
            this.hDebutPicker.TabIndex = 37;
            this.hDebutPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // hArriveePicker
            // 
            this.hArriveePicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hArriveePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hArriveePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hArriveePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hArriveePicker.CustomFormat = "HH:mm";
            this.hArriveePicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hArriveePicker.Location = new System.Drawing.Point(961, 311);
            this.hArriveePicker.Margin = new System.Windows.Forms.Padding(4);
            this.hArriveePicker.Name = "hArriveePicker";
            this.hArriveePicker.ShowUpDown = true;
            this.hArriveePicker.Size = new System.Drawing.Size(128, 49);
            this.hArriveePicker.TabIndex = 36;
            this.hArriveePicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // radioRdvFalse
            // 
            this.radioRdvFalse.AutoSize = true;
            this.radioRdvFalse.BackColor = System.Drawing.Color.Transparent;
            this.radioRdvFalse.ForeColor = System.Drawing.Color.Transparent;
            this.radioRdvFalse.Location = new System.Drawing.Point(372, 652);
            this.radioRdvFalse.Margin = new System.Windows.Forms.Padding(4);
            this.radioRdvFalse.Name = "radioRdvFalse";
            this.radioRdvFalse.Size = new System.Drawing.Size(17, 16);
            this.radioRdvFalse.TabIndex = 35;
            this.radioRdvFalse.TabStop = true;
            this.radioRdvFalse.UseVisualStyleBackColor = false;
            // 
            // radioRdvTrue
            // 
            this.radioRdvTrue.AutoSize = true;
            this.radioRdvTrue.BackColor = System.Drawing.Color.Transparent;
            this.radioRdvTrue.ForeColor = System.Drawing.Color.Transparent;
            this.radioRdvTrue.Location = new System.Drawing.Point(207, 652);
            this.radioRdvTrue.Margin = new System.Windows.Forms.Padding(4);
            this.radioRdvTrue.Name = "radioRdvTrue";
            this.radioRdvTrue.Size = new System.Drawing.Size(17, 16);
            this.radioRdvTrue.TabIndex = 34;
            this.radioRdvTrue.TabStop = true;
            this.radioRdvTrue.UseVisualStyleBackColor = false;
            // 
            // rdvFalseLabel
            // 
            this.rdvFalseLabel.AutoSize = true;
            this.rdvFalseLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvFalseLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvFalseLabel.Location = new System.Drawing.Point(284, 634);
            this.rdvFalseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdvFalseLabel.Name = "rdvFalseLabel";
            this.rdvFalseLabel.Size = new System.Drawing.Size(76, 41);
            this.rdvFalseLabel.TabIndex = 33;
            this.rdvFalseLabel.Text = "Non";
            // 
            // rdvTrueLabel
            // 
            this.rdvTrueLabel.AutoSize = true;
            this.rdvTrueLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvTrueLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvTrueLabel.Location = new System.Drawing.Point(128, 634);
            this.rdvTrueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdvTrueLabel.Name = "rdvTrueLabel";
            this.rdvTrueLabel.Size = new System.Drawing.Size(67, 41);
            this.rdvTrueLabel.TabIndex = 32;
            this.rdvTrueLabel.Text = "Oui";
            // 
            // rdvLabel
            // 
            this.rdvLabel.AutoSize = true;
            this.rdvLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvLabel.Location = new System.Drawing.Point(128, 522);
            this.rdvLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdvLabel.Name = "rdvLabel";
            this.rdvLabel.Size = new System.Drawing.Size(346, 41);
            this.rdvLabel.TabIndex = 31;
            this.rdvLabel.Text = "Visite sur rendez-vous ?";
            // 
            // hDepart
            // 
            this.hDepart.AutoSize = true;
            this.hDepart.BackColor = System.Drawing.Color.Transparent;
            this.hDepart.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepart.Location = new System.Drawing.Point(659, 530);
            this.hDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hDepart.Name = "hDepart";
            this.hDepart.Size = new System.Drawing.Size(246, 41);
            this.hDepart.TabIndex = 30;
            this.hDepart.Text = "Heure de départ";
            // 
            // hDebutLabel
            // 
            this.hDebutLabel.AutoSize = true;
            this.hDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.hDebutLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutLabel.Location = new System.Drawing.Point(659, 426);
            this.hDebutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hDebutLabel.Name = "hDebutLabel";
            this.hDebutLabel.Size = new System.Drawing.Size(236, 41);
            this.hDebutLabel.TabIndex = 29;
            this.hDebutLabel.Text = "Heure de début";
            // 
            // hArriveeLabel
            // 
            this.hArriveeLabel.AutoSize = true;
            this.hArriveeLabel.BackColor = System.Drawing.Color.Transparent;
            this.hArriveeLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveeLabel.Location = new System.Drawing.Point(659, 319);
            this.hArriveeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hArriveeLabel.Name = "hArriveeLabel";
            this.hArriveeLabel.Size = new System.Drawing.Size(234, 41);
            this.hArriveeLabel.TabIndex = 28;
            this.hArriveeLabel.Text = "Heure d\'arrivée";
            // 
            // dvisiteLabel
            // 
            this.dvisiteLabel.AutoSize = true;
            this.dvisiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.dvisiteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvisiteLabel.Location = new System.Drawing.Point(128, 341);
            this.dvisiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvisiteLabel.Name = "dvisiteLabel";
            this.dvisiteLabel.Size = new System.Drawing.Size(206, 41);
            this.dvisiteLabel.TabIndex = 27;
            this.dvisiteLabel.Text = "Date de visite";
            // 
            // medecinLabel
            // 
            this.medecinLabel.AutoSize = true;
            this.medecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.medecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinLabel.Location = new System.Drawing.Point(649, 98);
            this.medecinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medecinLabel.Name = "medecinLabel";
            this.medecinLabel.Size = new System.Drawing.Size(156, 41);
            this.medecinLabel.TabIndex = 26;
            this.medecinLabel.Text = "Médecin :";
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLabel.Location = new System.Drawing.Point(128, 98);
            this.cabinetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(141, 41);
            this.cabinetLabel.TabIndex = 25;
            this.cabinetLabel.Text = "Cabinet :";
            // 
            // UpdateVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1256, 828);
            this.Controls.Add(this.visiteDatePicker);
            this.Controls.Add(this.cabinetSelect);
            this.Controls.Add(this.medecinSelect);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.hDepartPicker);
            this.Controls.Add(this.hDebutPicker);
            this.Controls.Add(this.hArriveePicker);
            this.Controls.Add(this.radioRdvFalse);
            this.Controls.Add(this.radioRdvTrue);
            this.Controls.Add(this.rdvFalseLabel);
            this.Controls.Add(this.rdvTrueLabel);
            this.Controls.Add(this.rdvLabel);
            this.Controls.Add(this.hDepart);
            this.Controls.Add(this.hDebutLabel);
            this.Controls.Add(this.hArriveeLabel);
            this.Controls.Add(this.dvisiteLabel);
            this.Controls.Add(this.medecinLabel);
            this.Controls.Add(this.cabinetLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1274, 875);
            this.MinimumSize = new System.Drawing.Size(1274, 875);
            this.Name = "UpdateVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateVisite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker visiteDatePicker;
        private System.Windows.Forms.Label cabinetSelect;
        private System.Windows.Forms.Label medecinSelect;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.DateTimePicker hDepartPicker;
        private System.Windows.Forms.DateTimePicker hDebutPicker;
        private System.Windows.Forms.DateTimePicker hArriveePicker;
        private System.Windows.Forms.RadioButton radioRdvFalse;
        private System.Windows.Forms.RadioButton radioRdvTrue;
        private System.Windows.Forms.Label rdvFalseLabel;
        private System.Windows.Forms.Label rdvTrueLabel;
        private System.Windows.Forms.Label rdvLabel;
        private System.Windows.Forms.Label hDepart;
        private System.Windows.Forms.Label hDebutLabel;
        private System.Windows.Forms.Label hArriveeLabel;
        private System.Windows.Forms.Label dvisiteLabel;
        private System.Windows.Forms.Label medecinLabel;
        private System.Windows.Forms.Label cabinetLabel;
    }
}