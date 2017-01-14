using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Semestralka
{
    public partial class HlavniMenu : Form
    {
        Databaze databaze = new Databaze();
        SQLiteConnection pripojeni = new SQLiteConnection();
        Prikazy prikaz = new Prikazy();

        public HlavniMenu()
        {
            InitializeComponent();
            if (prikaz.CreateTabulka() == true)
                prikaz.CreateTabulka();
            else
                MessageBox.Show("Problém s vytvářením tabulky!");
        }     

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                SQLiteCommand select = new SQLiteCommand("SELECT * FROM jidlo", pripojeni);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = select;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Žádná jídla nejsou v databázi");
                }
                pripojeni.Close();
            }
            catch (Exception)
            {
                pripojeni.Close();
                MessageBox.Show("Problem s vypisem databaze!");
            }
        }

        private void buttonVyberToto_Click(object sender, EventArgs e)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM jidlo WHERE jmeno='" + textBoxSelectJidlo.Text.ToLower() + "'", pripojeni);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Takový produkt není v databázi");
                }
                pripojeni.Close();
            }
            catch
            {
                pripojeni.Close();
                MessageBox.Show("Problém s databází");
            }
        }
        private void buttonVlozitJidlo_Click(object sender, EventArgs e)
        {
            PridaniJidla pridaniJidla = new PridaniJidla();
            this.Hide();
            pridaniJidla.Show();

        }
    }
}
