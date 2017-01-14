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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPridej
            // 
            this.buttonPridej.Location = new System.Drawing.Point(208, 81);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Size = new System.Drawing.Size(297, 29);
            this.buttonPridej.TabIndex = 20;
            this.buttonPridej.Text = "Hotovo";
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.buttonPridej_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 384);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBoxSelectJidlo
            // 
            this.textBoxSelectJidlo.Location = new System.Drawing.Point(12, 86);
            this.textBoxSelectJidlo.Name = "textBoxSelectJidlo";
            this.textBoxSelectJidlo.Size = new System.Drawing.Size(190, 20);
            this.textBoxSelectJidlo.TabIndex = 18;
            this.textBoxSelectJidlo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSelectJidlo_KeyPress);
            // 
            // buttonZpet
            // 
            this.buttonZpet.Location = new System.Drawing.Point(12, 15);
            this.buttonZpet.Name = "buttonZpet";
            this.buttonZpet.Size = new System.Drawing.Size(75, 23);
            this.buttonZpet.TabIndex = 21;
            this.buttonZpet.Text = "Zpět";
            this.buttonZpet.UseVisualStyleBackColor = true;
            this.buttonZpet.Click += new System.EventHandler(this.buttonZpet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vyber jídlo co si snědl";
            // 
            // VyberZJidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZpet);
            this.Controls.Add(this.buttonPridej);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSelectJidlo);
            this.Name = "VyberZJidel";
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
    }
}