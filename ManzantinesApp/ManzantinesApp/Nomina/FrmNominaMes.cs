using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManzantinesApp.Classes;
using ManzantinesApp.DBContext;

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
            

            MesToolStripComboBox.ComboBox.DisplayMember = "Text";
            MesToolStripComboBox.ComboBox.ValueMember = "Value";

            AnioToolStripComboBox.ComboBox.DataSource = Anios.GetAnios(DateTime.Now.Year);
            MesToolStripComboBox.ComboBox.DataSource = Meses.GetMeses();

            AnioToolStripComboBox.ComboBox.SelectedValue = DateTime.Now.Year;
            MesToolStripComboBox.ComboBox.SelectedValue = DateTime.Now.Month;

            using (var db = new MazantinesEntities())
            {
                vvNominasEmpleadosMesBindingSource.DataSource = ToDataTable(db.vv_NominasEmpleadosMes
                    .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue && 
                        m.Anio == (int)AnioToolStripComboBox.ComboBox.SelectedValue).ToList());
                NominaDataGridView.DataSource = vvNominasEmpleadosMesBindingSource;
            }
        }

        private void UpdateNominaMes(int anio, int mes)
        {
            using (var db = new MazantinesEntities())
            {
                vvNominasEmpleadosMesBindingSource.DataSource = ToDataTable(db.vv_NominasEmpleadosMes
                    .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue &&
                        m.Anio == (int)AnioToolStripComboBox.ComboBox.SelectedValue).ToList());
                NominaDataGridView.DataSource = vvNominasEmpleadosMesBindingSource;
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

        private void MesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AnioToolStripComboBox.ComboBox.SelectedValue != null && MesToolStripComboBox.ComboBox.SelectedValue != null)
            {
                int anio = (int)AnioToolStripComboBox.ComboBox.SelectedValue;
                int mes = (int)MesToolStripComboBox.ComboBox.SelectedValue;
                UpdateNominaMes(anio, mes);
            }            
        }

        private void AnioToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnioToolStripComboBox.ComboBox.SelectedValue != null && MesToolStripComboBox.ComboBox.SelectedValue != null)
            {
                int anio = (int)AnioToolStripComboBox.ComboBox.SelectedValue;
                int mes = (int)MesToolStripComboBox.ComboBox.SelectedValue;
                UpdateNominaMes(anio, mes);
            }
        }
    }
}
