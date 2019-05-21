using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Nomina
{
    public partial class FrmEmpleoPago : Form
    {
        public FrmEmpleoPago()
        {
            InitializeComponent();
        }

        private void empleosPagosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.empleosPagosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEmpleoPago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Empleos' table. You can move, or remove it, as needed.
            this.empleosTableAdapter.Fill(this.dataSet1.Empleos);
            // TODO: This line of code loads data into the 'dataSet1.EmpleosPagos' table. You can move, or remove it, as needed.
            this.empleosPagosTableAdapter.Fill(this.dataSet1.EmpleosPagos);

        }
    }
}
