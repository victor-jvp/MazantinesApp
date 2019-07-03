using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManzantinesApp.DBContext;

namespace ManzantinesApp.Nomina
{
    public partial class FrmNominaMes : Form
    {
        #region Methods

        private void Inicializar()
        {
            MesToolStripComboBox.ComboBox.DisplayMember = "Text";
            MesToolStripComboBox.ComboBox.ValueMember = "Value";
            MesToolStripComboBox.ComboBox.DataSource = Classes.Meses.GetMeses();
            MesToolStripComboBox.ComboBox.SelectedValue = DateTime.Now.Month;

            using (var db = new MazantinesEntities())
            {
                vv_NominasEmpleadosMesBindingSource.DataSource = db.vv_NominasEmpleadosMes
                    .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue).ToList();
                NominaDataGridView.DataSource = vv_NominasEmpleadosMesBindingSource;
            }
        }

        private void UpdateNominaMes(int mes)
        {
            using (var db = new MazantinesEntities())
            {
                vv_NominasEmpleadosMesBindingSource.DataSource = db.vv_NominasEmpleadosMes
                    .Where(m => m.mesIni == (int)MesToolStripComboBox.ComboBox.SelectedValue).ToList();
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
            int mes = (int)MesToolStripComboBox.ComboBox.SelectedValue;
            UpdateNominaMes(mes);
        }
    }
}
