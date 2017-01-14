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
            this.buttonVyberToto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSelectJidlo = new System.Windows.Forms.TextBox();
            this.buttonZpet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVyberToto
            // 
            this.buttonVyberToto.Location = new System.Drawing.Point(173, 153);
            this.buttonVyberToto.Name = "buttonVyberToto";
            this.buttonVyberToto.Size = new System.Drawing.Size(210, 23);
            this.buttonVyberToto.TabIndex = 20;
            this.buttonVyberToto.Text = "Najti toto jídlo";
            this.buttonVyberToto.UseVisualStyleBackColor = true;
            this.buttonVyberToto.Click += new System.EventHandler(this.buttonVyberToto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 384);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBoxSelectJidlo
            // 
            this.textBoxSelectJidlo.Location = new System.Drawing.Point(13, 153);
            this.textBoxSelectJidlo.Name = "textBoxSelectJidlo";
            this.textBoxSelectJidlo.Size = new System.Drawing.Size(155, 20);
            this.textBoxSelectJidlo.TabIndex = 18;
            this.textBoxSelectJidlo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSelectJidlo_KeyPress);
            // 
            // buttonZpet
            // 
            this.buttonZpet.Location = new System.Drawing.Point(13, 13);
            this.buttonZpet.Name = "buttonZpet";
            this.buttonZpet.Size = new System.Drawing.Size(75, 23);
            this.buttonZpet.TabIndex = 21;
            this.buttonZpet.Text = "Zpět";
            this.buttonZpet.UseVisualStyleBackColor = true;
            this.buttonZpet.Click += new System.EventHandler(this.buttonZpet_Click);
            // 
            // VyberZJidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 578);
            this.Controls.Add(this.buttonZpet);
            this.Controls.Add(this.buttonVyberToto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSelectJidlo);
            this.Name = "VyberZJidel";
            this.Text = "VyberZJidel";
            this.Load += new System.EventHandler(this.VyberZJidel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVyberToto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSelectJidlo;
        private System.Windows.Forms.Button buttonZpet;
    }
}