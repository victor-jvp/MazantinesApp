using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp
{
    public partial class FrmEmpleos : Form
    {
        public FrmEmpleos()
        {
            InitializeComponent();
        }

        private void empleosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.empleosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmEmpleos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empleos' Puede moverla o quitarla según sea necesario.
            this.empleosTableAdapter.Fill(this.dataSet1.Empleos);

        }
    }
}
