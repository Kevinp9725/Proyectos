using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteleSys
{
    public partial class FrmMenuInventario : Form
    {
        public FrmMenuInventario()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCarrito Fc = new FrmCarrito();
            Fc.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
