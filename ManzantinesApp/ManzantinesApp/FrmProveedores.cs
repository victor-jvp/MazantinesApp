

namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;

    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FrmAddProveedor frmAddProveedor = new FrmAddProveedor();
            frmAddProveedor.ShowDialog(this);
            this.Enabled = true;

            if (frmAddProveedor.UpdateList)
            {
                this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (proveedoresDataGridView.CurrentRow == null) return;

            this.Enabled = false;
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();
            frmEditProveedor.miProveedor = dataSet1.Proveedores.FindById((int)proveedoresDataGridView.CurrentRow.Cells[0].Value);
            if (frmEditProveedor.miProveedor == null)
            {
                MessageBox.Show(
                    "El proveedor no pudo ser cargado, por favor intente de nuevo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            frmEditProveedor.ShowDialog(this);
            this.Enabled = true;

            if (frmEditProveedor.UpdateList)
            {
                this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            /*var confirm = MessageBox.Show(
                "Confirme eliminar el registro",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.No) return;

            try
            {
                var id_trabajador = (int)trabajadoresDataGridView.CurrentRow.Cells["Id"].Value;
                var query = this.dataSet1.Trabajadores_Empleos.Where(t => t.id_trabajador == id_trabajador);

                foreach (var row in query)
                {
                    row.Delete();
                }
                this.trabajadores_EmpleosTableAdapter.Update(this.dataSet1.Trabajadores_Empleos);

                var trabajador = this.dataSet1.Trabajadores.Where(t => t.Id == id_trabajador).FirstOrDefault();
                if (trabajador != null) trabajador.Delete();

                this.tableAdapterManager.UpdateAll(this.dataSet1);

                this.vv_empleadosTableAdapter.Fill(this.dataSet1.vv_empleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.trabajadoresBindingSource.CancelEdit();
            }*/
        }
    }
}
