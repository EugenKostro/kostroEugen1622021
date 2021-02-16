using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenZadatak1622021
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void ButtonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.ClearSelected();
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta forma2 = new UnosNovogStudenta();
            forma2.ShowDialog();
        }
    }
}
