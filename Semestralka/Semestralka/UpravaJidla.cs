using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestralka
{
    public partial class UpravaJidla : Form
    {

        Prikazy prikaz = new Prikazy();
        VyberZJidel vyberZJidla = new VyberZJidel();

        public UpravaJidla()
        {
            InitializeComponent();
        }

        private void buttonZpet_Click(object sender, EventArgs e)
        {
            Hide();
            vyberZJidla.Show();
        }

        private void UpravaJidla_Load(object sender, EventArgs e)
        {
            labelNapis.Text = "Napiš nové údaje pro " + Jidlo.jmeno + ":";
        }

        private void buttonZpet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonZpet.PerformClick();
            }
        }

        private void buttonUlozit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonUlozit.PerformClick();
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                prikaz.UpdateJidla(Jidlo.jmeno, Convert.ToInt32((textBoxKalorie.Text)), Convert.ToInt32(textBoxProteiny.Text),
                    Convert.ToInt32(textBoxSacharidy.Text), Convert.ToInt32(textBoxTuky.Text));
                MessageBox.Show("Jidlo úspěšně změněno!");
                Hide();
                vyberZJidla.Show();
            }
            catch
            {
                MessageBox.Show("Problém s uložením jídla, zkontrolujte prosím zadané údaje!");
            }
        }
    }
}
