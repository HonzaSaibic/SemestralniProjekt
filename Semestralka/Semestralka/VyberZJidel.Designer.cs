namespace Semestralka
{
    partial class VyberZJidel
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
            this.buttonPridej = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSelectJidlo = new System.Windows.Forms.TextBox();
            this.buttonZpet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVymazat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpravit = new System.Windows.Forms.Button();
            this.textBoxKolikG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPridej
            // 
            this.buttonPridej.Location = new System.Drawing.Point(324, 442);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Size = new System.Drawing.Size(79, 36);
            this.buttonPridej.TabIndex = 3;
            this.buttonPridej.Text = "Přidat do jídelníčku";
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.buttonPridej_Click);
            this.buttonPridej.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPridej_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // textBoxSelectJidlo
            // 
            this.textBoxSelectJidlo.Location = new System.Drawing.Point(12, 448);
            this.textBoxSelectJidlo.Name = "textBoxSelectJidlo";
            this.textBoxSelectJidlo.Size = new System.Drawing.Size(126, 20);
            this.textBoxSelectJidlo.TabIndex = 1;
            // 
            // buttonZpet
            // 
            this.buttonZpet.Location = new System.Drawing.Point(12, 15);
            this.buttonZpet.Name = "buttonZpet";
            this.buttonZpet.Size = new System.Drawing.Size(75, 23);
            this.buttonZpet.TabIndex = 6;
            this.buttonZpet.Text = "Zpět";
            this.buttonZpet.UseVisualStyleBackColor = true;
            this.buttonZpet.Click += new System.EventHandler(this.buttonZpet_Click);
            this.buttonZpet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonZpet_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Napiš jídlo";
            // 
            // buttonVymazat
            // 
            this.buttonVymazat.Location = new System.Drawing.Point(266, 523);
            this.buttonVymazat.Name = "buttonVymazat";
            this.buttonVymazat.Size = new System.Drawing.Size(137, 36);
            this.buttonVymazat.TabIndex = 5;
            this.buttonVymazat.Text = "Smazat z databáze";
            this.buttonVymazat.UseVisualStyleBackColor = true;
            this.buttonVymazat.Click += new System.EventHandler(this.buttonVymazat_Click);
            this.buttonVymazat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonVymazat_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kolik g?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vyber, co s ním udělat:";
            // 
            // buttonUpravit
            // 
            this.buttonUpravit.Location = new System.Drawing.Point(266, 481);
            this.buttonUpravit.Name = "buttonUpravit";
            this.buttonUpravit.Size = new System.Drawing.Size(137, 36);
            this.buttonUpravit.TabIndex = 4;
            this.buttonUpravit.Text = "Upravit hodnoty";
            this.buttonUpravit.UseVisualStyleBackColor = true;
            this.buttonUpravit.Click += new System.EventHandler(this.buttonUpravit_Click_1);
            this.buttonUpravit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonUpravit_KeyDown);
            // 
            // textBoxKolikG
            // 
            this.textBoxKolikG.Location = new System.Drawing.Point(266, 451);
            this.textBoxKolikG.Name = "textBoxKolikG";
            this.textBoxKolikG.Size = new System.Drawing.Size(52, 20);
            this.textBoxKolikG.TabIndex = 2;
            // 
            // VyberZJidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(567, 570);
            this.Controls.Add(this.textBoxKolikG);
            this.Controls.Add(this.buttonUpravit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVymazat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZpet);
            this.Controls.Add(this.buttonPridej);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSelectJidlo);
            this.Name = "VyberZJidel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VyberZJidel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VyberZJidel_FormClosed);
            this.Load += new System.EventHandler(this.VyberZJidel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPridej;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSelectJidlo;
        private System.Windows.Forms.Button buttonZpet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVymazat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpravit;
        private System.Windows.Forms.TextBox textBoxKolikG;
    }
}