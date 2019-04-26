

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
        public FrmAsientos()
        {
            InitializeComponent();
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            this.vv_table_asientosTableAdapter.Fill(this.rptDataSet.vv_table_asientos);
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

        }
    }
}
