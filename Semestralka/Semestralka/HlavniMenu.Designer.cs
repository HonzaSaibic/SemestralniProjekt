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
            this.buttonVypis = new System.Windows.Forms.Button();
            this.textBoxSelectJidlo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonVyberToto = new System.Windows.Forms.Button();
            this.buttonVlozitJidlo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVypis
            // 
            this.buttonVypis.Location = new System.Drawing.Point(12, 393);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(87, 23);
            this.buttonVypis.TabIndex = 1;
            this.buttonVypis.Text = "Vypis";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // textBoxSelectJidlo
            // 
            this.textBoxSelectJidlo.Location = new System.Drawing.Point(12, 152);
            this.textBoxSelectJidlo.Name = "textBoxSelectJidlo";
            this.textBoxSelectJidlo.Size = new System.Drawing.Size(210, 20);
            this.textBoxSelectJidlo.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(210, 179);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonVyberToto
            // 
            this.buttonVyberToto.Location = new System.Drawing.Point(12, 123);
            this.buttonVyberToto.Name = "buttonVyberToto";
            this.buttonVyberToto.Size = new System.Drawing.Size(210, 23);
            this.buttonVyberToto.TabIndex = 16;
            this.buttonVyberToto.Text = "Ukaz tohle jidlo";
            this.buttonVyberToto.UseVisualStyleBackColor = true;
            this.buttonVyberToto.Click += new System.EventHandler(this.buttonVyberToto_Click);
            // 
            // buttonVlozitJidlo
            // 
            this.buttonVlozitJidlo.Location = new System.Drawing.Point(125, 393);
            this.buttonVlozitJidlo.Name = "buttonVlozitJidlo";
            this.buttonVlozitJidlo.Size = new System.Drawing.Size(97, 23);
            this.buttonVlozitJidlo.TabIndex = 17;
            this.buttonVlozitJidlo.Text = "Uložit nové jídlo";
            this.buttonVlozitJidlo.UseVisualStyleBackColor = true;
            this.buttonVlozitJidlo.Click += new System.EventHandler(this.buttonVlozitJidlo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 512);
            this.Controls.Add(this.buttonVlozitJidlo);
            this.Controls.Add(this.buttonVyberToto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSelectJidlo);
            this.Controls.Add(this.buttonVypis);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonVypis;
        private System.Windows.Forms.TextBox textBoxSelectJidlo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonVyberToto;
        private System.Windows.Forms.Button buttonVlozitJidlo;
    }
}

