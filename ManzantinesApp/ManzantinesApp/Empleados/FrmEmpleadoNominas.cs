using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp.Empleados
{
    public partial class FrmEmpleadoNominas : Form
    {
        public int? id_trabajador { get; set; } = null;

        public FrmEmpleadoNominas()
        {
            InitializeComponent();
        }

        private void FrmEmpleadoNominas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rptDataSet.vv_resumenNominaEmpleado' table. You can move, or remove it, as needed.
            this.vv_resumenNominaEmpleadoTableAdapter.FillByIdEmpleado(this.rptDataSet.vv_resumenNominaEmpleado, id_trabajador);
        }
    }
}
