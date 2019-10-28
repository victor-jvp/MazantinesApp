
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
            
            AnioToolStripComboBox.ComboBox.DisplayMember = "Value";
            AnioToolStripComboBox.ComboBox.ValueMember = "Value";
            

            HastaToolStripComboBox.ComboBox.DisplayMember = "Text";
            HastaToolStripComboBox.ComboBox.ValueMember = "Value";

            AnioToolStripComboBox.ComboBox.DataSource = Anios.GetAnios(DateTime.Now.Year);
            HastaToolStripComboBox.ComboBox.DataSource = Meses.GetMeses();

            AnioToolStripComboBox.ComboBox.SelectedValue = DateTime.Now.Year;
            HastaToolStripComboBox.ComboBox.SelectedValue = DateTime.Now.Month;

            //using (var db = new MazantinesEntities())
            //{
            //    vvNominasEmpleadosMesBindingSource.DataSource = ToDataTable(db.vv_NominasEmpleadosMes
            //        .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue && 
            //            m.Anio == (int)AnioToolStripComboBox.ComboBox.SelectedValue).ToList());
            //    NominaDataGridView.DataSource = vvNominasEmpleadosMesBindingSource;
            //}
        }

        private void UpdateNominaMes(int anio, int mes)
        {
            //using (var db = new MazantinesEntities())
            //{
            //    vvNominasEmpleadosMesBindingSource.DataSource = ToDataTable(db.vv_NominasEmpleadosMes
            //        .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue &&
            //            m.Anio == (int)AnioToolStripComboBox.ComboBox.SelectedValue).ToList());
            //    NominaDataGridView.DataSource = vvNominasEmpleadosMesBindingSource;
            //}
            this.vv_NominasEmpleadosMesTableAdapter.FillByAnioAndMes(this.dataSet1.vv_NominasEmpleadosMes, anio, mes);
        }

        #endregion
        public FrmNominaMes()
        {
            InitializeComponent();
        }

        private void FrmNominaMes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.vv_NominasEmpleadosMes' table. You can move, or remove it, as needed.
            this.vv_NominasEmpleadosMesTableAdapter.Fill(this.dataSet1.vv_NominasEmpleadosMes);
            Inicializar();
        }

        private void MesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnioToolStripComboBox.ComboBox.SelectedValue != null && HastaToolStripComboBox.ComboBox.SelectedValue != null)
            {
                int anio = (int)AnioToolStripComboBox.ComboBox.SelectedValue;
                int mes = (int)HastaToolStripComboBox.ComboBox.SelectedValue;
                UpdateNominaMes(anio, mes);
            }            
        }

        private void AnioToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnioToolStripComboBox.ComboBox.SelectedValue != null && HastaToolStripComboBox.ComboBox.SelectedValue != null)
            {
                int anio = (int)AnioToolStripComboBox.ComboBox.SelectedValue;
                int mes = (int)HastaToolStripComboBox.ComboBox.SelectedValue;
                UpdateNominaMes(anio, mes);
            }
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
    }
}
