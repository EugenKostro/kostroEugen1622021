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
    public partial class UnosNovogStudenta : Form
    {
        public UnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void ButtonSnimi_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta forma2 = new UnosNovogStudenta();
            this.Close();
            forma2.Close();
        }
    }
}
