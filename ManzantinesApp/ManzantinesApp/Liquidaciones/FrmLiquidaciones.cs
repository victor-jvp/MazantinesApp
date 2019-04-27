using ManzantinesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Liquidaciones
{
    public partial class FrmLiquidaciones : Form
    {
        public FrmLiquidaciones()
        {
            InitializeComponent();
        }

        #region Methods
        private void FilterTable()
        {
            liquidacionesBindingSource.RemoveFilter();

            string valor = BuscarToolStripTextBox.Text.Trim();
            string filtro = string.Empty;

            //if (FechaFacturaCheckBox.Checked)
            //{
            //    filtro += $"FechaFactura = #{FechaFacturaDateTimePicker.Value.ToString("MM/dd/yyyy")}#";
            //}

            if (!string.IsNullOrEmpty(valor))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";

                filtro += $"Concepto LIKE '%{valor}%'";
            }

            if (!string.IsNullOrEmpty(filtro)) liquidacionesBindingSource.Filter = filtro;
        }
        #endregion

        private void LiquidacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.liquidacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FrmLiquidaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Liquidaciones' table. You can move, or remove it, as needed.
            this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmAddLiquidacion frmAddLiquidacion = new FrmAddLiquidacion();
            frmAddLiquidacion.ShowDialog(this);
            this.Enabled = true;

            if (frmAddLiquidacion.UpdateList)
            {
                this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Confirme eliminar el registro",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.No) return;

            try
            {
                var id = (int)liquidacionesDataGridView.CurrentRow.Cells["Id"].Value;
                var query = this.dataSet1.Liquidaciones.Where(t => t.Id == id);

                foreach (var row in query)
                {
                    row.Delete();
                }

                this.liquidacionesTableAdapter.Update(this.dataSet1.Liquidaciones);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (liquidacionesDataGridView.CurrentRow == null) return;

            this.Enabled = false;
            FrmEditLiquidacion frmEditLiquidacion = new FrmEditLiquidacion();
            frmEditLiquidacion.miLiquidacion = dataSet1.Liquidaciones.FindById((int)liquidacionesDataGridView.CurrentRow.Cells[0].Value);
            if (frmEditLiquidacion.miLiquidacion == null)
            {
                MessageBox.Show(
                    "El registro no pudo ser cargado, por favor intente de nuevo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }

            frmEditLiquidacion.ShowDialog(this);
            this.Enabled = true;

            if (frmEditLiquidacion.UpdateList)
            {
                this.liquidacionesTableAdapter.Fill(this.dataSet1.Liquidaciones);
            }
        }

        private void BuscarToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void TotalesToolStripButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmTotalesCategorias frmTotalesCategorias = new FrmTotalesCategorias();
            frmTotalesCategorias.ShowDialog(this);
            this.Enabled = true;
        }
    }
}
