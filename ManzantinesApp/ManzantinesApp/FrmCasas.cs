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
    public partial class FrmCasas : Form
    {
        public FrmCasas()
        {
            InitializeComponent();
        }

        private void FrmCasas_Load(object sender, EventArgs e)
        {
            this.vv_CasasCountEmpleadosTableAdapter1.Fill(this.dataSet1.vv_CasasCountEmpleados);

            if(vv_CasasCountEmpleadosDataGridView.RowCount > 0)
            {
                foreach (DataGridViewRow row in vv_CasasCountEmpleadosDataGridView.Rows)
                {
                    row.Cells["Calcular"].Value = 0;
                    row.Cells["totalEmpleados"].Value = 0;
                }
            }
        }

        private void casasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.casasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vv_CasasCountEmpleadosDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            
        }

        private void vv_CasasCountEmpleadosDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    int calcular = 0;
                    if (!int.TryParse(vv_CasasCountEmpleadosDataGridView.CurrentRow.Cells["Calcular"].Value.ToString(), out calcular))
                    {
                        MessageBox.Show(
                            "El valor ingresado no es válido, por favor verifiquelo e intente nuevamente.",
                            "Atención",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        vv_CasasCountEmpleadosDataGridView.CurrentRow.Cells["Calcular"].Value = 0;
                    }

                    int totalEmpleados = (int)this.vv_CasasCountEmpleadosDataGridView.CurrentRow.Cells["CantEmpleados"].Value;
                    vv_CasasCountEmpleadosDataGridView.CurrentRow.Cells["totalEmpleados"].Value = totalEmpleados - calcular;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
