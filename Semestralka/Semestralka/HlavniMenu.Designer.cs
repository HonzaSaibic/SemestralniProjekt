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
            this.SuspendLayout();
            // 
            // buttonVybratJidlo
            // 
            this.buttonVybratJidlo.Location = new System.Drawing.Point(12, 393);
            this.buttonVybratJidlo.Name = "buttonVybratJidlo";
            this.buttonVybratJidlo.Size = new System.Drawing.Size(112, 23);
            this.buttonVybratJidlo.TabIndex = 1;
            this.buttonVybratJidlo.Text = "Vybrat uložené jídlo";
            this.buttonVybratJidlo.UseVisualStyleBackColor = true;
            this.buttonVybratJidlo.Click += new System.EventHandler(this.buttonVybratJidlo_Click);
            // 
            // buttonVlozitJidlo
            // 
            this.buttonVlozitJidlo.Location = new System.Drawing.Point(130, 393);
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
            this.labelTuky.Location = new System.Drawing.Point(12, 260);
            this.labelTuky.Name = "labelTuky";
            this.labelTuky.Size = new System.Drawing.Size(94, 13);
            this.labelTuky.TabIndex = 24;
            this.labelTuky.Text = "Denní příjem tuků";
            // 
            // labelSacharidy
            // 
            this.labelSacharidy.AutoSize = true;
            this.labelSacharidy.Location = new System.Drawing.Point(12, 203);
            this.labelSacharidy.Name = "labelSacharidy";
            this.labelSacharidy.Size = new System.Drawing.Size(119, 13);
            this.labelSacharidy.TabIndex = 23;
            this.labelSacharidy.Text = "Denní příjem sacharidů";
            // 
            // labelProteiny
            // 
            this.labelProteiny.AutoSize = true;
            this.labelProteiny.Location = new System.Drawing.Point(12, 148);
            this.labelProteiny.Name = "labelProteiny";
            this.labelProteiny.Size = new System.Drawing.Size(111, 13);
            this.labelProteiny.TabIndex = 22;
            this.labelProteiny.Text = "Denní příjem proteinů";
            // 
            // labelNastavenyProtein
            // 
            this.labelNastavenyProtein.AutoSize = true;
            this.labelNastavenyProtein.Location = new System.Drawing.Point(151, 148);
            this.labelNastavenyProtein.Name = "labelNastavenyProtein";
            this.labelNastavenyProtein.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenyProtein.TabIndex = 25;
            this.labelNastavenyProtein.Text = "label1";
            // 
            // labelNastavenySacharid
            // 
            this.labelNastavenySacharid.AutoSize = true;
            this.labelNastavenySacharid.Location = new System.Drawing.Point(151, 203);
            this.labelNastavenySacharid.Name = "labelNastavenySacharid";
            this.labelNastavenySacharid.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenySacharid.TabIndex = 26;
            this.labelNastavenySacharid.Text = "label2";
            // 
            // labelNastavenyTuk
            // 
            this.labelNastavenyTuk.AutoSize = true;
            this.labelNastavenyTuk.Location = new System.Drawing.Point(151, 260);
            this.labelNastavenyTuk.Name = "labelNastavenyTuk";
            this.labelNastavenyTuk.Size = new System.Drawing.Size(35, 13);
            this.labelNastavenyTuk.TabIndex = 27;
            this.labelNastavenyTuk.Text = "label3";
            // 
            // HlavniMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 512);
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
    }
}

