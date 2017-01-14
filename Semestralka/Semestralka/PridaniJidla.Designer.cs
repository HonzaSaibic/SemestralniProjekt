namespace Semestralka
{
    partial class PridaniJidla
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
            this.textBoxTuky = new System.Windows.Forms.TextBox();
            this.textBoxSacharidy = new System.Windows.Forms.TextBox();
            this.textBoxProteiny = new System.Windows.Forms.TextBox();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.buttonVlozit = new System.Windows.Forms.Button();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelProteiny = new System.Windows.Forms.Label();
            this.labelSacharidy = new System.Windows.Forms.Label();
            this.labelTuky = new System.Windows.Forms.Label();
            this.buttonZpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTuky
            // 
            this.textBoxTuky.Location = new System.Drawing.Point(79, 266);
            this.textBoxTuky.Name = "textBoxTuky";
            this.textBoxTuky.Size = new System.Drawing.Size(122, 20);
            this.textBoxTuky.TabIndex = 11;
            // 
            // textBoxSacharidy
            // 
            this.textBoxSacharidy.Location = new System.Drawing.Point(79, 209);
            this.textBoxSacharidy.Name = "textBoxSacharidy";
            this.textBoxSacharidy.Size = new System.Drawing.Size(122, 20);
            this.textBoxSacharidy.TabIndex = 10;
            // 
            // textBoxProteiny
            // 
            this.textBoxProteiny.Location = new System.Drawing.Point(79, 155);
            this.textBoxProteiny.Name = "textBoxProteiny";
            this.textBoxProteiny.Size = new System.Drawing.Size(122, 20);
            this.textBoxProteiny.TabIndex = 9;
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(79, 99);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(122, 20);
            this.textBoxJmeno.TabIndex = 8;
            // 
            // buttonVlozit
            // 
            this.buttonVlozit.Location = new System.Drawing.Point(79, 311);
            this.buttonVlozit.Name = "buttonVlozit";
            this.buttonVlozit.Size = new System.Drawing.Size(122, 23);
            this.buttonVlozit.TabIndex = 7;
            this.buttonVlozit.Text = "Uložit produkt";
            this.buttonVlozit.UseVisualStyleBackColor = true;
            this.buttonVlozit.Click += new System.EventHandler(this.buttonVlozit_Click);
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(76, 83);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(83, 13);
            this.labelJmeno.TabIndex = 12;
            this.labelJmeno.Text = "Název produktu";
            // 
            // labelProteiny
            // 
            this.labelProteiny.AutoSize = true;
            this.labelProteiny.Location = new System.Drawing.Point(76, 139);
            this.labelProteiny.Name = "labelProteiny";
            this.labelProteiny.Size = new System.Drawing.Size(87, 13);
            this.labelProteiny.TabIndex = 13;
            this.labelProteiny.Text = "Proteiny na 100g";
            // 
            // labelSacharidy
            // 
            this.labelSacharidy.AutoSize = true;
            this.labelSacharidy.Location = new System.Drawing.Point(76, 193);
            this.labelSacharidy.Name = "labelSacharidy";
            this.labelSacharidy.Size = new System.Drawing.Size(96, 13);
            this.labelSacharidy.TabIndex = 14;
            this.labelSacharidy.Text = "Sacharidy na 100g";
            // 
            // labelTuky
            // 
            this.labelTuky.AutoSize = true;
            this.labelTuky.Location = new System.Drawing.Point(76, 250);
            this.labelTuky.Name = "labelTuky";
            this.labelTuky.Size = new System.Drawing.Size(73, 13);
            this.labelTuky.TabIndex = 15;
            this.labelTuky.Text = "Tuky na 100g";
            // 
            // buttonZpet
            // 
            this.buttonZpet.Location = new System.Drawing.Point(12, 12);
            this.buttonZpet.Name = "buttonZpet";
            this.buttonZpet.Size = new System.Drawing.Size(75, 23);
            this.buttonZpet.TabIndex = 16;
            this.buttonZpet.Text = "Zpět";
            this.buttonZpet.UseVisualStyleBackColor = true;
            this.buttonZpet.Click += new System.EventHandler(this.buttonZpet_Click);
            // 
            // PridaniJidla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 360);
            this.Controls.Add(this.buttonZpet);
            this.Controls.Add(this.labelTuky);
            this.Controls.Add(this.labelSacharidy);
            this.Controls.Add(this.labelProteiny);
            this.Controls.Add(this.labelJmeno);
            this.Controls.Add(this.textBoxTuky);
            this.Controls.Add(this.textBoxSacharidy);
            this.Controls.Add(this.textBoxProteiny);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.buttonVlozit);
            this.Name = "PridaniJidla";
            this.Text = "PridaniJidla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PridaniJidla_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTuky;
        private System.Windows.Forms.TextBox textBoxSacharidy;
        private System.Windows.Forms.TextBox textBoxProteiny;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Button buttonVlozit;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelProteiny;
        private System.Windows.Forms.Label labelSacharidy;
        private System.Windows.Forms.Label labelTuky;
        private System.Windows.Forms.Button buttonZpet;
    }
}