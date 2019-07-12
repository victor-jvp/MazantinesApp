

namespace ManzantinesApp
{
    using System;
    using System.Linq;
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
                this.Enabled = true;
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
            var confirm = MessageBox.Show(
                "Confirme eliminar el registro",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.No) return;

            try
            {
                var id = (int)proveedoresDataGridView.CurrentRow.Cells["Id"].Value;
                var query = this.dataSet1.Proveedores.Where(t => t.Id == id);

                foreach (var row in query)
                {
                    row.Delete();
                }

                this.proveedoresTableAdapter.Update(this.dataSet1.Proveedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.proveedoresBindingSource.CancelEdit();
            }
        }

        private void BuscarToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void BuscarToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void FiltrarDatos()
        {
            string filtrar = BuscarToolStripTextBox.Text.Trim();
            if (string.IsNullOrEmpty(filtrar))
            {
                proveedoresBindingSource.RemoveFilter();
                return;
            }

            string filtro = $"CIF LIKE '%{filtrar}%' OR RazonSocial LIKE '%{filtrar}%' OR Telefono LIKE '%{filtrar}%' OR Email LIKE '%{filtrar}%'";
            proveedoresBindingSource.Filter = filtro;
        }
    }
}
