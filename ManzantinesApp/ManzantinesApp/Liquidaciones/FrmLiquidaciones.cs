using CrystalDecisions.Shared;
using ManzantinesApp.Data;
using ManzantinesApp.Reports;
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

            if (PagadasRadioButton.Checked)
            {
                filtro += $"Pagado = 1";
            }

            if (SinPagarRadioButton.Checked)
            {
                filtro += $"Pagado = 0";
            }

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
            // TODO: This line of code loads data into the 'dataSet1.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf|*.pdf";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptLiquidaciones();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.liquidacionesBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Liquidaciones";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = saveFileDialog.FileName;
                    exportOptions = frmPreviewCrystal.ReporteCrystal.ExportOptions;
                    {
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                        exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                        exportOptions.ExportFormatOptions = new PdfFormatOptions();
                    }
                    frmPreviewCrystal.ReporteCrystal.Export();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptLiquidaciones();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.liquidacionesBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Liquidaciones";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);
                frmPreviewCrystal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }

        private void TodasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TodasRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void PagadasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PagadasRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void SinPagarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SinPagarRadioButton.Checked)
            {
                FilterTable();
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel|*.xlsx";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptLiquidaciones();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.liquidacionesBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "Liquidaciones";
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = saveFileDialog.FileName;
                    exportOptions = frmPreviewCrystal.ReporteCrystal.ExportOptions;
                    {
                        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                        exportOptions.ExportFormatType = ExportFormatType.ExcelWorkbook;
                        exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                        exportOptions.ExportFormatOptions = new ExcelFormatOptions();
                    }
                    frmPreviewCrystal.ReporteCrystal.Export();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Enabled = true;
        }
    }
}
