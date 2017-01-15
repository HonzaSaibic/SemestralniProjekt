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
        VypocetProcent procenta = new VypocetProcent();

        public VyberZJidel()
        {
            InitializeComponent();
        }

        private void buttonZpet_Click(object sender, EventArgs e)
        {
            Hide();
            HlavniMenu hlavniMenu = new HlavniMenu();
            hlavniMenu.Show();
        }
        private void buttonPridej_Click(object sender, EventArgs e)
        {
            try
            {
                prikaz.NahraniVybranehoJidla(textBoxSelectJidlo.Text);

                // podivam se, jestli je takove jidlo v databazi. 
                // Jelikoz ukladam do databaze pouze male pismena, musim tedy hledat pres male pismena
                if (prikaz.KontrolaJidla(textBoxSelectJidlo.Text.ToLower()) == true)
                {
                    try
                    {
                        // dost nepekne napsane pocitani dennin prijmu(pricitani jidla k jiz danym hodnotam)
                        double procentaKalorie = procenta.Procento(ObjektAktualniPrijem.pridanyKalorie, Convert.ToInt32(textBoxKolikG.Text));
                        double procentaProteinu = procenta.Procento(ObjektAktualniPrijem.pridanyProteiny, Convert.ToInt32(textBoxKolikG.Text));
                        double procentaSacharidu = procenta.Procento(ObjektAktualniPrijem.pridanySacharidy, Convert.ToInt32(textBoxKolikG.Text));
                        double procentaTuku = procenta.Procento(ObjektAktualniPrijem.pridanyTuky, Convert.ToInt32(textBoxKolikG.Text));
                        ObjektAktualniPrijem.kalorie = Convert.ToInt32(procentaKalorie) + ObjektAktualniPrijem.kalorie;
                        ObjektAktualniPrijem.proteiny = Convert.ToInt32(procentaProteinu) + ObjektAktualniPrijem.proteiny;
                        ObjektAktualniPrijem.sacharidy = Convert.ToInt32(procentaSacharidu) + ObjektAktualniPrijem.sacharidy;
                        ObjektAktualniPrijem.tuky = Convert.ToInt32(procentaTuku) + ObjektAktualniPrijem.tuky;

                        prikaz.VymazaniAktualnihoPrijmu();
                        prikaz.InsertAktualniPrijem(Convert.ToInt32(ObjektAktualniPrijem.kalorie), Convert.ToInt32(ObjektAktualniPrijem.proteiny),
                            Convert.ToInt32(ObjektAktualniPrijem.sacharidy), Convert.ToInt32(ObjektAktualniPrijem.tuky));

                        MessageBox.Show("Úspěšně přidáno do dnešního jídelníčku!");

                        textBoxSelectJidlo.Text = "";
                        textBoxKolikG.Text = "";
                    }
                    catch (FormatException)
                    {
                        if (textBoxKolikG.Text == "")
                        {
                            MessageBox.Show("Vyberte, kolik gramů chcete uložit.");
                        }
                        else
                        {
                            MessageBox.Show("Zadejte prosím číslo!");
                        }
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
        private void buttonVymazat_Click(object sender, EventArgs e)
        {
            if (textBoxSelectJidlo.Text != "")
            {
                if (prikaz.KontrolaJidla(textBoxSelectJidlo.Text.ToLower()) == true)
                {
                    // pokud se v messageboxu vybere Yes, smaze se jidlo a datagrid se znovu naplni novyma hodnotama
                    DialogResult vyber = MessageBox.Show("Opravdu chcete jídlo smazat?", "Ano", MessageBoxButtons.YesNo);
                    if (vyber == DialogResult.Yes)
                    {
                        prikaz.SmazaniJidla(textBoxSelectJidlo.Text);
                        textBoxSelectJidlo.Text = "";
                        dataGridView1.DataSource = prikaz.NacteniDatabaze();
                        if (prikaz.NacteniDatabaze() == null)
                        {
                            MessageBox.Show("Databáze je prázdná! Přidejte si jídlo.");
                            Hide();
                            PridaniJidla pridani = new PridaniJidla();
                            pridani.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Takové jídlo není v databázi!");
                }
            }
            else
            {
                MessageBox.Show("Vyberte si jídlo.");
            }
        }
        private void VyberZJidel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPridej_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPridej.PerformClick();
            }
        }

        private void buttonZpet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonZpet.PerformClick();
            }
        }

        private void buttonUpravit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonUpravit.PerformClick();
            }
        }
        private void buttonVymazat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonVymazat.PerformClick();
            }
        }

        private void buttonUpravit_Click_1(object sender, EventArgs e)
        {
            if (textBoxSelectJidlo.Text != "")
            {
                if (prikaz.KontrolaJidla(textBoxSelectJidlo.Text.ToLower()) == true)
                {
                    Jidlo.jmeno = textBoxSelectJidlo.Text;
                    Hide();
                    UpravaJidla uprava = new UpravaJidla();
                    uprava.Show();
                }
                else
                {
                    MessageBox.Show("Takové jídlo není v databázi!");
                }
            }
            else
            {
                MessageBox.Show("Vyberte si jídlo.");
            }
        }

        private void VyberZJidel_Load(object sender, EventArgs e)
        {
            // nacteni dat do datagridu pres metodu nacteniDatabaze
            try
            {
                dataGridView1.DataSource = prikaz.NacteniDatabaze();
            }
            catch (Exception)
            {
                MessageBox.Show("Nastal problém s databází");
            }
        }
    }
}
