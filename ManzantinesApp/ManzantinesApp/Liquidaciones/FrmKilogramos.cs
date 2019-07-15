using ManzantinesApp.DBContext;
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
    public partial class FrmKilogramos : Form
    {
        private void Inicalizar()
        {
            try
            {
                using (var db = new MazantinesEntities())
                {
                    FrutaComboBox.ValueMember = "Id";
                    FrutaComboBox.DisplayMember = "Fruta";
                    FrutaComboBox.DataSource = db.Frutas.OrderBy(f => f.Fruta).ToList();
                    FrutaComboBox.SelectedIndex = -1;

                    FincaComboBox.ValueMember = "Id";
                    FincaComboBox.DisplayMember = "Finca";
                    FincaComboBox.DataSource = db.Fincas.OrderBy(f => f.Finca).ToList();
                    FincaComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en Metodo Inicializar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        public FrmKilogramos()
        {
            InitializeComponent();
            this.FechaDateTimePicker.Value = DateTime.Now;
        }

        private void FrmKilogramos_Load(object sender, EventArgs e)
        {
            Inicalizar();
        }
    }
}
