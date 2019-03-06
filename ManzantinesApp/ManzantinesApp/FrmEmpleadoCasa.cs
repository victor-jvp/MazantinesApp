namespace ManzantinesApp
{
    using CrystalDecisions.Shared;
    using Reports;
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class FrmEmpleadoCasa : Form
    {
        #region Properties
        public int NroCasa { get; set; } = -1;
        #endregion

        public FrmEmpleadoCasa()
        {
            InitializeComponent();
        }

        private void FrmEmpleadoCasa_Load(object sender, EventArgs e)
        {
            if(NroCasa < 0)
            {
                MessageBox.Show("El Nro de Casa no fue definido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: This line of code loads data into the 'dataSet1.vv_EmpleadosCasas' table. You can move, or remove it, as needed.
            this.vv_EmpleadosCasasTableAdapter.FillByNroCasa(this.dataSet1.vv_EmpleadosCasas, NroCasa);

            this.Text += $" Número: [{NroCasa}]";
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pdf|*.pdf";

                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptEmpleadosCasa();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_EmpleadosCasasBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_EmpleadosCasas";
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
                frmPreviewCrystal.ReporteCrystal = new RptEmpleadosCasa();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_EmpleadosCasasBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_EmpleadosCasas";
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

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptEmpleadosCasa();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vv_EmpleadosCasasBindingSource.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_EmpleadosCasas";
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
    }
}
