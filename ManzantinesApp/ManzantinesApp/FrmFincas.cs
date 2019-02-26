using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManzantinesApp.Data;

namespace ManzantinesApp
{
    public partial class FrmFincas : Form
    {
        public FrmFincas()
        {
            InitializeComponent();
        }

        private void FrmFincas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Encargados' table. You can move, or remove it, as needed.
            this.encargadosTableAdapter.Fill(this.dataSet1.Encargados);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Fincas' Puede moverla o quitarla según sea necesario.
            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
        }

        private void fincasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fincasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
