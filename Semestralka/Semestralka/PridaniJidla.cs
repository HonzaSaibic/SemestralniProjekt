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
            if (prikaz.KontrolaJidla(textBoxJmeno.Text) == false)
            {
                if (prikaz.Insert(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text) == true)
                {
                    prikaz.Insert(textBoxJmeno.Text, textBoxProteiny.Text, textBoxSacharidy.Text, textBoxTuky.Text);
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
    }
}
