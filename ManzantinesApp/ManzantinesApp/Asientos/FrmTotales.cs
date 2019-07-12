using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Asientos
{
    partial class FrmTotales : Form
    {
        public FrmTotales()
        {
            InitializeComponent();
        }

        private void FrmTotales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rptDataSet.vv_totales_asientos' table. You can move, or remove it, as needed.
            this.vv_totales_asientosTableAdapter.Fill(this.rptDataSet.vv_totales_asientos);
            //AsientosPorPagarTextBox.Text = 
        }
    }
}
