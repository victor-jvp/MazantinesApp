namespace ManzantinesApp
{
    using System;
    using System.Windows.Forms;
    using Data;

    public partial class FrmEditEmpleado : Form
    {
        #region Properties
        public DataSet1.vv_trabajadoresTableRow miTrabajador { get; set; } = null;
        public bool UpdateList { get; set; } = false;
        #endregion

        #region Constructor
        public FrmEditEmpleado()
        {
            InitializeComponent();
        } 
        #endregion


        private void FrmEditEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Casas' Puede moverla o quitarla según sea necesario.
            this.casasTableAdapter.FillTrim(this.dataSet1.Casas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empleos' Puede moverla o quitarla según sea necesario.
            this.empleosTableAdapter.FillTrim(this.dataSet1.Empleos);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Fincas' Puede moverla o quitarla según sea necesario.
            this.fincasTableAdapter.FillTrim(this.dataSet1.Fincas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.FillTrim(this.dataSet1.Empresas);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Trabajadores' Puede moverla o quitarla según sea necesario.
            this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);

            if(miTrabajador == null)
            {
                trabajadoresBindingSource.AddNew();
            }
            else
            {
                this.trabajadoresBindingSource.Position = trabajadoresBindingSource.Find("Id", miTrabajador.Id);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.trabajadoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                this.UpdateList = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
