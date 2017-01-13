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
    public partial class Form1 : Form
    {
        Databaze databaze = new Databaze();
        SQLiteConnection pripojeni = new SQLiteConnection();
        Prikazy prikaz = new Prikazy();

        public Form1()
        {
            InitializeComponent();
            if (prikaz.tabulka() == true)
                prikaz.tabulka();
            else
                MessageBox.Show("Problém s vytvářením tabulky!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Vlozeni_Click(object sender, EventArgs e)
        {
                
            if (prikaz.insert(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text) == true)
            {
                prikaz.insert(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text);
            }
            else
            {
                MessageBox.Show("Takové jídlo je již obsaženo");
            }

        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            //prikaz.select(labelSelectJmeno.Text, labelSelectProteiny.Text, labelSelectSacharidy.Text, labelSelectTuky.Text);

         /*   pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            string select = "SELECT * FROM jidlo ";
            SQLiteCommand prikaz = new SQLiteCommand(select, pripojeni);
            SQLiteDataReader reader = prikaz.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.Text = "Jmeno: " + reader["jmeno"] + ", proteiny: " +
                    reader["proteiny"] + ", sacharidy: " + reader["sacharidy"] + ", tuky: " + reader["tuky"];
              
            }
            pripojeni.Close();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            string select = "SELECT jmeno FROM jidlo ";
            SQLiteCommand prikaz = new SQLiteCommand(select, pripojeni);
            SQLiteDataReader reader = prikaz.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Text = reader["jmeno"].ToString();
            }
            pripojeni.Close(); 
        }
    }
}
