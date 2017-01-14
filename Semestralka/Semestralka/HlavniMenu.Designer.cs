namespace Semestralka
{
    partial class HlavniMenu
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
            this.buttonVybratJidlo = new System.Windows.Forms.Button();
            this.buttonVlozitJidlo = new System.Windows.Forms.Button();
            this.buttonDenniPrijem = new System.Windows.Forms.Button();
            this.labelTuky = new System.Windows.Forms.Label();
            this.labelSacharidy = new System.Windows.Forms.Label();
            this.labelProteiny = new System.Windows.Forms.Label();
            this.labelNastavenyProtein = new System.Windows.Forms.Label();
            this.labelNastavenySacharid = new System.Windows.Forms.Label();
            this.labelNastavenyTuk = new System.Windows.Forms.Label();
            this.labelAktualniProtein = new System.Windows.Forms.Label();
            this.labelAktualniSacharid = new System.Windows.Forms.Label();
            this.labelAktualniTuk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVybratJidlo
            // 
            this.buttonVybratJidlo.Location = new System.Drawing.Point(53, 464);
            this.buttonVybratJidlo.Name = "buttonVybratJidlo";
            this.buttonVybratJidlo.Size = new System.Drawing.Size(112, 23);
            this.buttonVybratJidlo.TabIndex = 1;
            this.buttonVybratJidlo.Text = "Vybrat uložené jídlo";
            this.buttonVybratJidlo.UseVisualStyleBackColor = true;
            this.buttonVybratJidlo.Click += new System.EventHandler(this.buttonVybratJidlo_Click);
            // 
            // buttonVlozitJidlo
            // 
            this.buttonVlozitJidlo.Location = new System.Drawing.Point(212, 464);
            this.buttonVlozitJidlo.Name = "buttonVlozitJidlo";
            this.buttonVlozitJidlo.Size = new System.Drawing.Size(112, 23);
            this.buttonVlozitJidlo.TabIndex = 17;
            this.buttonVlozitJidlo.Text = "Uložit nové jídlo";
            this.buttonVlozitJidlo.UseVisualStyleBackColor = true;
            this.buttonVlozitJidlo.Click += new System.EventHandler(this.buttonVlozitJidlo_Click);
            // 
            // buttonDenniPrijem
            // 
            this.buttonDenniPrijem.Location = new System.Drawing.Point(53, 70);
            this.buttonDenniPrijem.Name = "buttonDenniPrijem";
            this.buttonDenniPrijem.Size = new System.Drawing.Size(139, 23);
            this.buttonDenniPrijem.TabIndex = 18;
            this.buttonDenniPrijem.Text = "Nastavit denní příjem";
            this.buttonDenniPrijem.UseVisualStyleBackColor = true;
            this.buttonDenniPrijem.Click += new System.EventHandler(this.buttonDenniPrijem_Click);
            // 
            // labelTuky
            // 
            this.labelTuky.AutoSize = true;
            this.labelTuky.Location = new System.Drawing.Point(50, 335);
            this.labelTuky.Name = "labelTuky";
            this.labelTuky.Size = new System.Drawing.Size(94, 13);
            this.labelTuky.TabIndex = 24;
            this.labelTuky.Text = "Denní příjem tuků";
            // 
            // labelSacharidy
            // 
            this.labelSacharidy.AutoSize = true;
            this.labelSacharidy.Location = new System.Drawing.Point(50, 252);
            this.labelSacharidy.Name = "labelSacharidy";
            this.labelSacharidy.Size = new System.Drawing.Size(119, 13);
            this.labelSacharidy.TabIndex = 23;
            this.labelSacharidy.Text = "Denní příjem sacharidů";
            // 
            // labelProteiny
            // 
            this.labelProteiny.AutoSize = true;
            this.labelProteiny.Location = new System.Drawing.Point(50, 173);
            this.labelProteiny.Name = "labelProteiny";
            this.labelProteiny.Size = new System.Drawing.Size(111, 13);
            this.labelProteiny.TabIndex = 22;
            this.labelProteiny.Text = "Denní příjem proteinů";
            // 
            // labelNastavenyProtein
            // 
            this.labelNastavenyProtein.AutoSize = true;
            this.labelNastavenyProtein.Location = new System.Drawing.Point(266, 173);
            this.labelNastavenyProtein.Name = "labelNastavenyProtein";
            this.labelNastavenyProtein.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenyProtein.TabIndex = 25;
            this.labelNastavenyProtein.Text = "label1";
            // 
            // labelNastavenySacharid
            // 
            this.labelNastavenySacharid.AutoSize = true;
            this.labelNastavenySacharid.Location = new System.Drawing.Point(266, 252);
            this.labelNastavenySacharid.Name = "labelNastavenySacharid";
            this.labelNastavenySacharid.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenySacharid.TabIndex = 26;
            this.labelNastavenySacharid.Text = "label2";
            // 
            // labelNastavenyTuk
            // 
            this.labelNastavenyTuk.AutoSize = true;
            this.labelNastavenyTuk.Location = new System.Drawing.Point(266, 335);
            this.labelNastavenyTuk.Name = "labelNastavenyTuk";
            this.labelNastavenyTuk.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenyTuk.TabIndex = 27;
            this.labelNastavenyTuk.Text = "label3";
            // 
            // labelAktualniProtein
            // 
            this.labelAktualniProtein.AutoSize = true;
            this.labelAktualniProtein.Location = new System.Drawing.Point(225, 173);
            this.labelAktualniProtein.Name = "labelAktualniProtein";
            this.labelAktualniProtein.Size = new System.Drawing.Size(35, 13);
            this.labelAktualniProtein.TabIndex = 28;
            this.labelAktualniProtein.Text = "label1";
            // 
            // labelAktualniSacharid
            // 
            this.labelAktualniSacharid.AutoSize = true;
            this.labelAktualniSacharid.Location = new System.Drawing.Point(225, 252);
            this.labelAktualniSacharid.Name = "labelAktualniSacharid";
            this.labelAktualniSacharid.Size = new System.Drawing.Size(35, 13);
            this.labelAktualniSacharid.TabIndex = 29;
            this.labelAktualniSacharid.Text = "label2";
            // 
            // labelAktualniTuk
            // 
            this.labelAktualniTuk.AutoSize = true;
            this.labelAktualniTuk.Location = new System.Drawing.Point(225, 335);
            this.labelAktualniTuk.Name = "labelAktualniTuk";
            this.labelAktualniTuk.Size = new System.Drawing.Size(35, 13);
            this.labelAktualniTuk.TabIndex = 30;
            this.labelAktualniTuk.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Aktuální";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nastavený";
            // 
            // HlavniMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 585);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAktualniTuk);
            this.Controls.Add(this.labelAktualniSacharid);
            this.Controls.Add(this.labelAktualniProtein);
            this.Controls.Add(this.labelNastavenyTuk);
            this.Controls.Add(this.labelNastavenySacharid);
            this.Controls.Add(this.labelNastavenyProtein);
            this.Controls.Add(this.labelTuky);
            this.Controls.Add(this.labelSacharidy);
            this.Controls.Add(this.labelProteiny);
            this.Controls.Add(this.buttonDenniPrijem);
            this.Controls.Add(this.buttonVlozitJidlo);
            this.Controls.Add(this.buttonVybratJidlo);
            this.Name = "HlavniMenu";
            this.Text = "Hlavní menu";
            this.Load += new System.EventHandler(this.HlavniMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonVybratJidlo;
        private System.Windows.Forms.Button buttonVlozitJidlo;
        private System.Windows.Forms.Button buttonDenniPrijem;
        private System.Windows.Forms.Label labelTuky;
        private System.Windows.Forms.Label labelSacharidy;
        private System.Windows.Forms.Label labelProteiny;
        private System.Windows.Forms.Label labelNastavenyProtein;
        private System.Windows.Forms.Label labelNastavenySacharid;
        private System.Windows.Forms.Label labelNastavenyTuk;
        private System.Windows.Forms.Label labelAktualniProtein;
        private System.Windows.Forms.Label labelAktualniSacharid;
        private System.Windows.Forms.Label labelAktualniTuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

