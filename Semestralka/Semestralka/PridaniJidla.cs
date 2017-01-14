using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Semestralka
{
    public partial class PridaniJidla : Form
    {

        Prikazy prikaz = new Prikazy();

        public PridaniJidla()
        {
            InitializeComponent();
        }

        private void buttonVlozit_Click(object sender, EventArgs e)
        {
            // Pokud je metoda KontrolaJidla false, znamena to, ze takove jmeno neni v databazi
            if (prikaz.KontrolaJidla(textBoxJmeno.Text.ToLower()) == false)
            {
                // Pokud je InsertJidlo true, znamena to, ze vse probehlo v poradku a muzu tedy pridavat jidlo
                if (prikaz.InsertJidlo(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text) == true)
                {
                    prikaz.InsertJidlo(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text);
                    MessageBox.Show("Úpěšně uloženo!");
                    textBoxJmeno.Text = "";
                    textBoxProteiny.Text = "";
                    textBoxSacharidy.Text = "";
                    textBoxTuky.Text = "";
                }

                else
                {
                    MessageBox.Show("Překontrolujte si zadané hodnoty.");
                }
            }
            else
            {
                MessageBox.Show("Takové jídlo je již v databázi.");
            }
        }

        private void buttonZpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            HlavniMenu hlavniMenu = new HlavniMenu();
            hlavniMenu.Show();
        }

        private void PridaniJidla_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
