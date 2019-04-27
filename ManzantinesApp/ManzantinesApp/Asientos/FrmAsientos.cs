﻿

namespace ManzantinesApp.Asientos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmAsientos : Form
    {
        #region Methods

        private void Inicializar()
        {
            this.vv_table_asientosTableAdapter.Fill(this.rptDataSet.vv_table_asientos);
            this.asientosTableAdapter1.Fill(this.dataSet.Asientos);

            FechaFacturaDateTimePicker.Value = DateTime.Now;
            FechaPagoDateTimePicker.Value = DateTime.Now;

            FechaFacturaDateTimePicker.Enabled = false;
            FechaPagoDateTimePicker.Enabled = false;

            FechaFacturaCheckBox.Checked = false;
            FechaPagoCheckBox.Checked = false;
        }

        private void FilterTable()
        {
            vv_table_asientosBindingSource.RemoveFilter();

            string valor = BuscarToolStripTextBox.Text.Trim();
            string filtro = string.Empty;

            if (FechaFacturaCheckBox.Checked)
            {
                filtro += $"FechaFactura = #{FechaFacturaDateTimePicker.Value.ToString("MM/dd/yyyy")}#";
            }

            if (!string.IsNullOrEmpty(valor))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";

                filtro +=
                $"(RazonSocial LIKE '%{valor}%' OR " +
                $"FormaPago LIKE '%{valor}%' OR " +
                $"NroCuenta LIKE '%{valor}%')";
            }

            if (!string.IsNullOrEmpty(filtro)) vv_table_asientosBindingSource.Filter = filtro;                
        }

        #endregion

        public FrmAsientos()
        {
            InitializeComponent();
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmAddAsiento frmAddAsiento = new FrmAddAsiento();
            frmAddAsiento.ShowDialog(this);
            this.Enabled = true;

            if (frmAddAsiento.UpdateList)
            {
                this.vv_table_asientosTableAdapter.Fill(this.rptDataSet.vv_table_asientos);
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmEditAsiento frmEditAsiento = new FrmEditAsiento();
            frmEditAsiento.miAsiento = dataSet.Asientos.FindById((int)asientosDataGridView.CurrentRow.Cells[0].Value);
            if (frmEditAsiento.miAsiento == null)
            {
                MessageBox.Show(
                    "El proveedor no pudo ser cargado, por favor intente de nuevo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }

            frmEditAsiento.ShowDialog(this);
            this.Enabled = true;

            if (frmEditAsiento.UpdateList)
            {
                this.vv_table_asientosTableAdapter.Fill(this.rptDataSet.vv_table_asientos);
            }
        }

        private void FechaFacturaCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (FechaFacturaCheckBox.Checked)
                FechaFacturaDateTimePicker.Enabled = true;
            else
                FechaFacturaDateTimePicker.Enabled = false;

            FilterTable();
        }

        private void FechaPagoCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (FechaPagoCheckBox.Checked)
            {
                FechaPagoDateTimePicker.Enabled = true;
            }
            else
            {
                FechaPagoDateTimePicker.Enabled = false;
            }
        }

        private void BuscarToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void FechaFacturaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterTable();
        }

        private void TotalesToolStripButton_Click(object sender, EventArgs e)
        {
            FrmTotales frmTotales = new FrmTotales();
            frmTotales.ShowDialog(this);
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
                var id = (int)asientosDataGridView.CurrentRow.Cells["Id"].Value;
                var query = this.dataSet.Asientos.Where(t => t.Id == id);

                foreach (var row in query)
                {
                    row.Delete();
                }

                this.asientosTableAdapter1.Update(this.dataSet.Asientos);

                this.vv_table_asientosTableAdapter.Fill(this.rptDataSet.vv_table_asientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
