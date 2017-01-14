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
                DenniPrijem.proteiny = Convert.ToInt32(textBoxProteiny.Text);
                DenniPrijem.sacharidy = Convert.ToInt32(textBoxProteiny.Text);
                DenniPrijem.tuky = Convert.ToInt32(textBoxTuky.Text);

                MessageBox.Show("Denní příjem nastaven!");
                Hide();
                HlavniMenu hlavniMenu = new HlavniMenu();
                hlavniMenu.Show();
            /*    textBoxProteiny.Text = "";
                textBoxSacharidy.Text = "";
                textBoxTuky.Text = "";*/
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
    }
}
