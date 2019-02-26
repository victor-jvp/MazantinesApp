namespace ManzantinesApp
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Data;

    public partial class FrmEditEmpleado : Form
    {
        #region Properties
        public DataSet1.TrabajadoresRow miTrabajador { get; set; } = null;
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
            this.encargadosTableAdapter.Fill(this.dataSet1.Encargados);
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            this.empleosTableAdapter.Fill(this.dataSet1.Empleos);
            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
            this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            this.trabajadores_EmpleosTableAdapter.Fill(this.dataSet1.Trabajadores_Empleos);

            if (miTrabajador == null)
            {
                this.fincaComboBox.SelectedIndex = -1;
                trabajadoresBindingSource.AddNew();                
            }
            else
            {
                this.trabajadoresBindingSource.Position = trabajadoresBindingSource.Find("Id", miTrabajador.Id);
                if(miTrabajador.id_casa == 0)
                {
                    this.fincaComboBox.SelectedIndex = -1;
                }
                else
                {
                    DataSet1.CasasDataTable miCasa = this.casasTableAdapter.GetDataById(miTrabajador.id_casa);
                    DataSet1.CasasRow miRow = miCasa[0];
                    fincaComboBox.SelectedValue = miRow.id_finca;
                    fincaComboBox_SelectedIndexChanged(sender, e);
                    nroCasaComboBox.SelectedValue = miTrabajador.id_casa;
                }                              
            }            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.trabajadoresBindingSource.EndEdit();
                this.tableAdapterManager.TrabajadoresTableAdapter.Update(this.dataSet1);
                this.tableAdapterManager.Trabajadores_EmpleosTableAdapter.Update(this.dataSet1);
                //this.tableAdapterManager.UpdateAll(this.dataSet1);
                this.UpdateList = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fincaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.fincaComboBox.DataSource == null || this.fincaComboBox.SelectedValue == null) return;
                int finca = -1;
                if (int.TryParse(fincaComboBox.SelectedValue.ToString(), out finca))
                {
                    this.casasTableAdapter.FillByFinca(this.dataSet1.Casas, (int)fincaComboBox.SelectedValue);
                    this.nroCasaComboBox.DataSource = casasBindingSource;
                    this.nroCasaComboBox.SelectedIndex = -1;
                    this.nroCasaComboBox.Enabled = true;
                }
                else
                {
                    this.nroCasaComboBox.DataSource = null;
                    this.nroCasaComboBox.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void QuitarFototoolStripButton_Click(object sender, EventArgs e)
        {
            foto2PictureBox.Image = null;
        }

        private void foto2PictureBox_Click(object sender, EventArgs e)
        {
            PictureOpenFileDialog.Filter = "jpg|*.jpg|png|*.png";
            PictureOpenFileDialog.ValidateNames = true;
            PictureOpenFileDialog.Multiselect = false;

            if (PictureOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                foto2PictureBox.Image = Image.FromFile(PictureOpenFileDialog.FileName);
            }
        }
    }
}
