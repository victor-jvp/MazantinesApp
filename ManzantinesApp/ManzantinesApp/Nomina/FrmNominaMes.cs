
using ManzantinesApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ManzantinesApp.Nomina
{
    public partial class FrmNominaMes : Form
    {
        #region Methods

        private static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void Inicializar()
        {
            try
            {
                this.vv_NominasEmpleadosMesTableAdapter.Fill(this.dataSet1.vv_NominasEmpleadosMes);

                this.DesdeDateTimePicker.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
                this.HastaDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                this.DesdeDateTimePicker.MaxDate = this.HastaDateTimePicker.Value;
                this.HastaDateTimePicker.MinDate = this.DesdeDateTimePicker.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en Inicializar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion
        public FrmNominaMes()
        {
            InitializeComponent();
        }

        private void FrmNominaMes_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var dt = new DataTable();
            dt = this.dataSet1.vv_NominasEmpleadosMes.Copy();
            ManzantinesApp.Classes.Reports.VistaPreliminar(new RptNominaPorMes(), dt);
            this.Enabled = true;
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
            {
                CrystalDecisions.Shared.ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel|*.xlsx";

                Reports.FrmPreviewCrystal frmPreviewCrystal = new Reports.FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = new RptNominaPorMes();

                DataSet ds = new DataSet();
                DataView view = (DataView)this.vvNominasEmpleadosMesBindingSource1.List;
                DataTable dt = view.ToTable();
                dt.TableName = "vv_NominasEmpleadosMes";
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

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void FiltrarDatos()
        {
            int anioIni = DesdeDateTimePicker.Value.Year;
            int anioFin = HastaDateTimePicker.Value.Year;
            int mesIni = DesdeDateTimePicker.Value.Month;
            int mesFin = HastaDateTimePicker.Value.Month;

            this.vv_NominasEmpleadosMesTableAdapter.FillByFechaRango(this.dataSet1.vv_NominasEmpleadosMes, anioIni, anioFin, mesIni, mesFin);
        }

        private void NominaDataGridView_Validated(object sender, EventArgs e)
        {
            
        }

        private void HastaDateTimePicker_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
