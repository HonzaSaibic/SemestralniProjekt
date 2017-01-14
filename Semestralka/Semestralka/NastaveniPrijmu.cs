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
    public partial class NastaveniPrijmu : Form
    {
        Prikazy prikaz = new Prikazy();

        public NastaveniPrijmu()
        {
            InitializeComponent();
        }

        private void NastaveniPrijmu_Load(object sender, EventArgs e)
        {

        }

        private void buttonNastavit_Click(object sender, EventArgs e)
        {
            try
            {
                ObjektDenniPrijem.kalorie = Convert.ToInt32(textBoxKalorie.Text);
                ObjektDenniPrijem.proteiny = Convert.ToInt32(textBoxProteiny.Text);
                ObjektDenniPrijem.sacharidy = Convert.ToInt32(textBoxSacharidy.Text);
                ObjektDenniPrijem.tuky = Convert.ToInt32(textBoxTuky.Text);

                MessageBox.Show("Denní příjem nastaven!");

                try
                {
                    prikaz.VymazaniPoslednihoPrijmu();
                    prikaz.InsertDenniPrijem(Convert.ToInt32(textBoxKalorie.Text),Convert.ToInt32(textBoxProteiny.Text), Convert.ToInt32(textBoxSacharidy.Text), Convert.ToInt32(textBoxTuky.Text));
                }
                catch
                {
                    MessageBox.Show("Problem s ulozenim do databaze! Zkontrolujte zadané údaje");
                }

                Hide();
                HlavniMenu hlavniMenu = new HlavniMenu();
                hlavniMenu.Show();
            }
            catch
            {
                MessageBox.Show("Zadávat se dají pouze čísla!");
            }
        }

        private void buttonZpet_Click(object sender, EventArgs e)
        {
            Hide();
            HlavniMenu hlavniMenu = new HlavniMenu();
            hlavniMenu.Show();
        }

        private void NastaveniPrijmu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
