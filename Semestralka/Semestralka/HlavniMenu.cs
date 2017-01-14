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

            // Zavolana metoda pro vytvoreni tabulky pri startu
            if (prikaz.CreateTabulka() == true)
                prikaz.CreateTabulka();
            else
                MessageBox.Show("Problém s vytvářením tabulky!");

            // Nastaveni parametru
            labelNastavenyProtein.Text = Convert.ToString(DenniPrijem.proteiny);
            labelNastavenySacharid.Text = Convert.ToString(DenniPrijem.sacharidy);
            labelNastavenyTuk.Text = Convert.ToString(DenniPrijem.tuky);
        }          
          
        private void buttonVlozitJidlo_Click(object sender, EventArgs e)
        {
            PridaniJidla pridaniJidla = new PridaniJidla();
            this.Hide();
            pridaniJidla.Show();

        }

        private void buttonVybratJidlo_Click(object sender, EventArgs e)
        {
            Hide();
            VyberZJidel vyberZJidel = new VyberZJidel();
            vyberZJidel.Show();
        }

        private void buttonDenniPrijem_Click(object sender, EventArgs e)
        {
            Hide();
            NastaveniPrijmu nastaveniPrijmu = new NastaveniPrijmu();
            nastaveniPrijmu.Show();

        }

        private void HlavniMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
