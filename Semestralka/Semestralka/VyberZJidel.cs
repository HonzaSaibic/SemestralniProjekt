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
    public partial class VyberZJidel : Form
    {
        SQLiteConnection pripojeni = new SQLiteConnection();
        Databaze databaze = new Databaze();
        Prikazy prikaz = new Prikazy();

        public VyberZJidel()
        {
            InitializeComponent();
        }

        private void VyberZJidel_Load(object sender, EventArgs e)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                SQLiteCommand select = new SQLiteCommand("SELECT jmeno AS Jidlo ,kalorie AS 'Kcal', proteiny AS 'Protein na 100g',sacharidy AS 'Sacharidy na 100g',tuky AS 'Tuky na 100g' FROM jidlo", pripojeni);
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


        private void buttonZpet_Click(object sender, EventArgs e)
        {
            Hide();
            HlavniMenu hlavniMenu = new HlavniMenu();
            hlavniMenu.Show();
        }

        private void textBoxSelectJidlo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buttonPridej_Click(object sender, EventArgs e)
        {
            try
            {
                prikaz.NahraniVybranehoJidla(textBoxSelectJidlo.Text);
               
                if (prikaz.KontrolaJidla(textBoxSelectJidlo.Text) == true)
                {
                    try
                    {
                        ObjektAktualniPrijem.kalorie = ObjektAktualniPrijem.pridanyKalorie + ObjektAktualniPrijem.kalorie;
                        ObjektAktualniPrijem.proteiny = ObjektAktualniPrijem.pridanyProteiny + ObjektAktualniPrijem.proteiny;
                        ObjektAktualniPrijem.sacharidy = ObjektAktualniPrijem.pridanySacharidy + ObjektAktualniPrijem.sacharidy;
                        ObjektAktualniPrijem.tuky = ObjektAktualniPrijem.pridanyTuky + ObjektAktualniPrijem.tuky;

                        prikaz.VymazaniAktualnihoPrijmu();
                        prikaz.InsertAktualniPrijem(Convert.ToInt32(ObjektAktualniPrijem.kalorie),Convert.ToInt32(ObjektAktualniPrijem.proteiny),
                            Convert.ToInt32(ObjektAktualniPrijem.sacharidy), Convert.ToInt32(ObjektAktualniPrijem.tuky));

                        MessageBox.Show("Úspěšně přidáno do dnešního jídelníčku!");

                    }
                    catch
                    {
                        MessageBox.Show("Problem s databazi! Zkuste prosim znovu");
                    }
                }
                else
                {
                    MessageBox.Show("Takové jídlo v databázi není!");
                }

                
            }
            catch
            {
                MessageBox.Show("Zadávat se dají pouze čísla!");
            }
        }

        private void VyberZJidel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
