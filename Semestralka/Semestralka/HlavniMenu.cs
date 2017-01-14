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

            
            prikaz.NahraniDenniPrijmu();
            prikaz.NahraniAktualnihoPrijmu();
            
            // zapsani parametru do labelů
            labelNastavenyKalorie.Text = Convert.ToString(ObjektDenniPrijem.kalorie);
            labelNastavenyProtein.Text = Convert.ToString(ObjektDenniPrijem.proteiny);
            labelNastavenySacharid.Text = Convert.ToString(ObjektDenniPrijem.sacharidy);
            labelNastavenyTuk.Text = Convert.ToString(ObjektDenniPrijem.tuky);

            labelAktualniKalorie.Text = Convert.ToString(ObjektAktualniPrijem.kalorie);
            labelAktualniProtein.Text = Convert.ToString(ObjektAktualniPrijem.proteiny);
            labelAktualniSacharid.Text = Convert.ToString(ObjektAktualniPrijem.sacharidy);
            labelAktualniTuk.Text = Convert.ToString(ObjektAktualniPrijem.tuky);

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            prikaz.VymazaniAktualnihoPrijmu();
            labelAktualniProtein.Text = "0";
            labelAktualniSacharid.Text = "0";
            labelAktualniTuk.Text = "0";
            labelAktualniKalorie.Text = "0";
            ObjektAktualniPrijem.kalorie = 0;
            ObjektAktualniPrijem.proteiny = 0;
            ObjektAktualniPrijem.sacharidy = 0;
            ObjektAktualniPrijem.tuky = 0;
        }

        private void HlavniMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
