namespace Semestralka
{
    partial class NastaveniPrijmu
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
            this.buttonZpet = new System.Windows.Forms.Button();
            this.labelTuky = new System.Windows.Forms.Label();
            this.labelSacharidy = new System.Windows.Forms.Label();
            this.labelProteiny = new System.Windows.Forms.Label();
            this.textBoxTuky = new System.Windows.Forms.TextBox();
            this.textBoxSacharidy = new System.Windows.Forms.TextBox();
            this.textBoxProteiny = new System.Windows.Forms.TextBox();
            this.buttonNastavit = new System.Windows.Forms.Button();
            this.labelOkraj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKalorie = new System.Windows.Forms.Label();
            this.textBoxKalorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonZpet
            // 
            this.buttonZpet.Location = new System.Drawing.Point(12, 12);
            this.buttonZpet.Name = "buttonZpet";
            this.buttonZpet.Size = new System.Drawing.Size(75, 23);
            this.buttonZpet.TabIndex = 6;
            this.buttonZpet.Text = "Zpět";
            this.buttonZpet.UseVisualStyleBackColor = true;
            this.buttonZpet.Click += new System.EventHandler(this.buttonZpet_Click);
            this.buttonZpet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonZpet_KeyDown);
            // 
            // labelTuky
            // 
            this.labelTuky.AutoSize = true;
            this.labelTuky.Location = new System.Drawing.Point(82, 240);
            this.labelTuky.Name = "labelTuky";
            this.labelTuky.Size = new System.Drawing.Size(94, 13);
            this.labelTuky.TabIndex = 21;
            this.labelTuky.Text = "Denní příjem tuků";
            // 
            // labelSacharidy
            // 
            this.labelSacharidy.AutoSize = true;
            this.labelSacharidy.Location = new System.Drawing.Point(82, 183);
            this.labelSacharidy.Name = "labelSacharidy";
            this.labelSacharidy.Size = new System.Drawing.Size(119, 13);
            this.labelSacharidy.TabIndex = 20;
            this.labelSacharidy.Text = "Denní příjem sacharidů";
            // 
            // labelProteiny
            // 
            this.labelProteiny.AutoSize = true;
            this.labelProteiny.Location = new System.Drawing.Point(82, 129);
            this.labelProteiny.Name = "labelProteiny";
            this.labelProteiny.Size = new System.Drawing.Size(111, 13);
            this.labelProteiny.TabIndex = 19;
            this.labelProteiny.Text = "Denní příjem proteinů";
            // 
            // textBoxTuky
            // 
            this.textBoxTuky.Location = new System.Drawing.Point(85, 256);
            this.textBoxTuky.Name = "textBoxTuky";
            this.textBoxTuky.Size = new System.Drawing.Size(122, 20);
            this.textBoxTuky.TabIndex = 4;
            // 
            // textBoxSacharidy
            // 
            this.textBoxSacharidy.Location = new System.Drawing.Point(85, 199);
            this.textBoxSacharidy.Name = "textBoxSacharidy";
            this.textBoxSacharidy.Size = new System.Drawing.Size(122, 20);
            this.textBoxSacharidy.TabIndex = 3;
            // 
            // textBoxProteiny
            // 
            this.textBoxProteiny.Location = new System.Drawing.Point(85, 145);
            this.textBoxProteiny.Name = "textBoxProteiny";
            this.textBoxProteiny.Size = new System.Drawing.Size(122, 20);
            this.textBoxProteiny.TabIndex = 2;
            // 
            // buttonNastavit
            // 
            this.buttonNastavit.Location = new System.Drawing.Point(85, 301);
            this.buttonNastavit.Name = "buttonNastavit";
            this.buttonNastavit.Size = new System.Drawing.Size(122, 23);
            this.buttonNastavit.TabIndex = 5;
            this.buttonNastavit.Text = "Nastavit";
            this.buttonNastavit.UseVisualStyleBackColor = true;
            this.buttonNastavit.Click += new System.EventHandler(this.buttonNastavit_Click);
            this.buttonNastavit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonNastavit_KeyDown);
            // 
            // labelOkraj
            // 
            this.labelOkraj.AutoSize = true;
            this.labelOkraj.Location = new System.Drawing.Point(290, 22);
            this.labelOkraj.Name = "labelOkraj";
            this.labelOkraj.Size = new System.Drawing.Size(0, 13);
            this.labelOkraj.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // labelKalorie
            // 
            this.labelKalorie.AutoSize = true;
            this.labelKalorie.Location = new System.Drawing.Point(82, 77);
            this.labelKalorie.Name = "labelKalorie";
            this.labelKalorie.Size = new System.Drawing.Size(102, 13);
            this.labelKalorie.TabIndex = 26;
            this.labelKalorie.Text = "Denní příjem kalorií";
            // 
            // textBoxKalorie
            // 
            this.textBoxKalorie.Location = new System.Drawing.Point(85, 93);
            this.textBoxKalorie.Name = "textBoxKalorie";
            this.textBoxKalorie.Size = new System.Drawing.Size(122, 20);
            this.textBoxKalorie.TabIndex = 1;
            // 
            // NastaveniPrijmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(302, 360);
            this.Controls.Add(this.labelKalorie);
            this.Controls.Add(this.textBoxKalorie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOkraj);
            this.Controls.Add(this.buttonNastavit);
            this.Controls.Add(this.labelTuky);
            this.Controls.Add(this.labelSacharidy);
            this.Controls.Add(this.labelProteiny);
            this.Controls.Add(this.textBoxTuky);
            this.Controls.Add(this.textBoxSacharidy);
            this.Controls.Add(this.textBoxProteiny);
            this.Controls.Add(this.buttonZpet);
            this.Name = "NastaveniPrijmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavení denního příjmu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NastaveniPrijmu_FormClosed);
            this.Load += new System.EventHandler(this.NastaveniPrijmu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZpet;
        private System.Windows.Forms.Label labelTuky;
        private System.Windows.Forms.Label labelSacharidy;
        private System.Windows.Forms.Label labelProteiny;
        private System.Windows.Forms.TextBox textBoxTuky;
        private System.Windows.Forms.TextBox textBoxSacharidy;
        private System.Windows.Forms.TextBox textBoxProteiny;
        private System.Windows.Forms.Button buttonNastavit;
        private System.Windows.Forms.Label labelOkraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKalorie;
        private System.Windows.Forms.TextBox textBoxKalorie;
    }
}