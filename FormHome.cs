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
    public partial class FormHome : Form
    {
        private Form FormActual;
        private Form FormActual1;
        private bool clickMemReport;
        public FormHome()
        {
            InitializeComponent();
            clickMemReport = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
        }


        private void buttonReportes_Click(object sender, EventArgs e)
        {
            
            if (clickMemReport)
            {
                panelCategoriaReportes.Enabled = false;
                panelCategoriaReportes.Visible = false;
                clickMemReport = false;
            }
            else
            {
                panelCategoriaReportes.Enabled = true;
                panelCategoriaReportes.Visible = true;
                clickMemReport = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmConfiguracionUsuarios());
            if (FormActual1 != null)
            {
                //Mantener un solo form
                FormActual1.Close();
            }

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void panelMainFrm_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            if (clickMemReport)
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                clickMemReport = false;
            }
            else
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                clickMemReport = true;
            }
        }

        private void OpenForm(Form FormHijo)
        {
            if (FormActual != null)
            {
                //Mantener un solo form
                FormActual.Close();
            }
            FormActual = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelMainFrm.Controls.Add(FormHijo);
            panelMainFrm.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            
        }

            private void OpenForm1(Form FormHijo1)
        {
            if (FormActual1 != null)
            {
                //Mantener un solo form
                FormActual1.Close();
            }
            FormActual1 = FormHijo1;
            FormHijo1.TopLevel = false;
            FormHijo1.FormBorderStyle = FormBorderStyle.None;
            FormHijo1.Dock = DockStyle.Fill;
            panelToolBar.Controls.Add(FormHijo1);
            panelToolBar.Tag = FormHijo1;
            FormHijo1.BringToFront();
            FormHijo1.Show();
          

        }
        private void buttonInventario_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmInventario());
            OpenForm1(new FrmMenuInventario());

        }

        private void buttonReportesInventario_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            if (FormActual1 != null)
            {
                //Mantener un solo form
                FormActual1.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAverias_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAverias());
            OpenForm1(new FrmMenuAveria());
        }

        private void buttonMantenimiento_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMantenimientoDetallado());
            OpenForm1(new FrmMenuMantenimiento());
        }

        private void buttonReportesAverias_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            if (FormActual1 != null)
            {
                //Mantener un solo form
                FormActual1.Close();
            }
        }

        private void buttonReportesMantenimiento_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmReportes());
            if (FormActual1 != null)
            {
                //Mantener un solo form
                FormActual1.Close();
            }
        }
 
    }
}
