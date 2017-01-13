namespace Semestralka
{
    partial class Form1
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
            this.Vlozeni = new System.Windows.Forms.Button();
            this.buttonVypis = new System.Windows.Forms.Button();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxProteiny = new System.Windows.Forms.TextBox();
            this.textBoxSacharidy = new System.Windows.Forms.TextBox();
            this.textBoxTuky = new System.Windows.Forms.TextBox();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelProteiny = new System.Windows.Forms.Label();
            this.labelSacharidy = new System.Windows.Forms.Label();
            this.labelTuky = new System.Windows.Forms.Label();
            this.labelSelectJmeno = new System.Windows.Forms.Label();
            this.labelSelectProteiny = new System.Windows.Forms.Label();
            this.labelSelectSacharidy = new System.Windows.Forms.Label();
            this.labelSelectTuky = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Vlozeni
            // 
            this.Vlozeni.Location = new System.Drawing.Point(36, 371);
            this.Vlozeni.Name = "Vlozeni";
            this.Vlozeni.Size = new System.Drawing.Size(122, 23);
            this.Vlozeni.TabIndex = 0;
            this.Vlozeni.Text = "Vlozit";
            this.Vlozeni.UseVisualStyleBackColor = true;
            this.Vlozeni.Click += new System.EventHandler(this.Vlozeni_Click);
            // 
            // buttonVypis
            // 
            this.buttonVypis.Location = new System.Drawing.Point(250, 371);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(124, 23);
            this.buttonVypis.TabIndex = 1;
            this.buttonVypis.Text = "Vypis";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(36, 182);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(100, 20);
            this.textBoxJmeno.TabIndex = 3;
            // 
            // textBoxProteiny
            // 
            this.textBoxProteiny.Location = new System.Drawing.Point(36, 234);
            this.textBoxProteiny.Name = "textBoxProteiny";
            this.textBoxProteiny.Size = new System.Drawing.Size(100, 20);
            this.textBoxProteiny.TabIndex = 4;
            // 
            // textBoxSacharidy
            // 
            this.textBoxSacharidy.Location = new System.Drawing.Point(36, 284);
            this.textBoxSacharidy.Name = "textBoxSacharidy";
            this.textBoxSacharidy.Size = new System.Drawing.Size(100, 20);
            this.textBoxSacharidy.TabIndex = 5;
            // 
            // textBoxTuky
            // 
            this.textBoxTuky.Location = new System.Drawing.Point(36, 335);
            this.textBoxTuky.Name = "textBoxTuky";
            this.textBoxTuky.Size = new System.Drawing.Size(100, 20);
            this.textBoxTuky.TabIndex = 6;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(36, 163);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(38, 13);
            this.labelJmeno.TabIndex = 7;
            this.labelJmeno.Text = "Jmeno";
            // 
            // labelProteiny
            // 
            this.labelProteiny.AutoSize = true;
            this.labelProteiny.Location = new System.Drawing.Point(36, 215);
            this.labelProteiny.Name = "labelProteiny";
            this.labelProteiny.Size = new System.Drawing.Size(45, 13);
            this.labelProteiny.TabIndex = 8;
            this.labelProteiny.Text = "Proteiny";
            // 
            // labelSacharidy
            // 
            this.labelSacharidy.AutoSize = true;
            this.labelSacharidy.Location = new System.Drawing.Point(36, 268);
            this.labelSacharidy.Name = "labelSacharidy";
            this.labelSacharidy.Size = new System.Drawing.Size(54, 13);
            this.labelSacharidy.TabIndex = 9;
            this.labelSacharidy.Text = "Sacharidy";
            // 
            // labelTuky
            // 
            this.labelTuky.AutoSize = true;
            this.labelTuky.Location = new System.Drawing.Point(36, 316);
            this.labelTuky.Name = "labelTuky";
            this.labelTuky.Size = new System.Drawing.Size(31, 13);
            this.labelTuky.TabIndex = 10;
            this.labelTuky.Text = "Tuky";
            // 
            // labelSelectJmeno
            // 
            this.labelSelectJmeno.AutoSize = true;
            this.labelSelectJmeno.Location = new System.Drawing.Point(210, 189);
            this.labelSelectJmeno.Name = "labelSelectJmeno";
            this.labelSelectJmeno.Size = new System.Drawing.Size(0, 13);
            this.labelSelectJmeno.TabIndex = 11;
            // 
            // labelSelectProteiny
            // 
            this.labelSelectProteiny.AutoSize = true;
            this.labelSelectProteiny.Location = new System.Drawing.Point(210, 245);
            this.labelSelectProteiny.Name = "labelSelectProteiny";
            this.labelSelectProteiny.Size = new System.Drawing.Size(0, 13);
            this.labelSelectProteiny.TabIndex = 12;
            this.labelSelectProteiny.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSelectSacharidy
            // 
            this.labelSelectSacharidy.AutoSize = true;
            this.labelSelectSacharidy.Location = new System.Drawing.Point(213, 294);
            this.labelSelectSacharidy.Name = "labelSelectSacharidy";
            this.labelSelectSacharidy.Size = new System.Drawing.Size(0, 13);
            this.labelSelectSacharidy.TabIndex = 13;
            // 
            // labelSelectTuky
            // 
            this.labelSelectTuky.AutoSize = true;
            this.labelSelectTuky.Location = new System.Drawing.Point(213, 345);
            this.labelSelectTuky.Name = "labelSelectTuky";
            this.labelSelectTuky.Size = new System.Drawing.Size(0, 13);
            this.labelSelectTuky.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 512);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSelectTuky);
            this.Controls.Add(this.labelSelectSacharidy);
            this.Controls.Add(this.labelSelectProteiny);
            this.Controls.Add(this.labelSelectJmeno);
            this.Controls.Add(this.labelTuky);
            this.Controls.Add(this.labelSacharidy);
            this.Controls.Add(this.labelProteiny);
            this.Controls.Add(this.labelJmeno);
            this.Controls.Add(this.textBoxTuky);
            this.Controls.Add(this.textBoxSacharidy);
            this.Controls.Add(this.textBoxProteiny);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.buttonVypis);
            this.Controls.Add(this.Vlozeni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vlozeni;
        private System.Windows.Forms.Button buttonVypis;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxProteiny;
        private System.Windows.Forms.TextBox textBoxSacharidy;
        private System.Windows.Forms.TextBox textBoxTuky;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelProteiny;
        private System.Windows.Forms.Label labelSacharidy;
        private System.Windows.Forms.Label labelTuky;
        private System.Windows.Forms.Label labelSelectJmeno;
        private System.Windows.Forms.Label labelSelectProteiny;
        private System.Windows.Forms.Label labelSelectSacharidy;
        private System.Windows.Forms.Label labelSelectTuky;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

