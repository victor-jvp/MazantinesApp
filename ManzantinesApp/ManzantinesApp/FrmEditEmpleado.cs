namespace ManzantinesApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;
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

            if (miTrabajador == null)
            {
                this.fincaComboBox.SelectedIndex = -1;
                trabajadoresBindingSource.AddNew();                
            }
            else
            {
                this.trabajadoresBindingSource.Position = trabajadoresBindingSource.Find("Id", miTrabajador.Id);
                this.trabajadores_EmpleosTableAdapter.FillByIdTrabajador(this.dataSet1.Trabajadores_Empleos, (int)miTrabajador.Id);
                if (miTrabajador.id_casa == 0)
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

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;
                this.Validate();
                this.trabajadoresBindingSource.EndEdit();

                this.trabajadoresTableAdapter.Update(dataSet1.Trabajadores);
                int cury_id_trabajador = 0;
                if(miTrabajador == null)
                {
                    cury_id_trabajador = this.dataSet1.Trabajadores.AsEnumerable().Select(f => f.Id).Max();

                    foreach (DataSet1.Trabajadores_EmpleosRow item in dataSet1.Trabajadores_Empleos.Rows)
                    {
                        this.tableAdapterManager.Trabajadores_EmpleosTableAdapter.Insert(Convert.ToInt32(cury_id_trabajador), item.id_empleo);
                    }
                }
                else
                {
                    cury_id_trabajador = miTrabajador.Id;
                    //this.tableAdapterManager.Trabajadores_EmpleosTableAdapter.DeleteById_trabajador(cury_id_trabajador);
                    this.trabajadores_EmpleosTableAdapter.Update(this.dataSet1.Trabajadores_Empleos);
                }
                
                this.UpdateList = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            ErrorProvider error = new ErrorProvider();
            if(nroCasaComboBox.SelectedIndex == -1)
            {
                error.SetError(nroCasaComboBox, "Este campo es requerido");
                nroCasaComboBox.Focus();
                return false;
            }

            return true;
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

        private void trabajadores_EmpleosDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*try
            {
                var empleo = e.FormattedValue.ToString();
                if (string.IsNullOrEmpty(empleo))
                {
                    e.Cancel = true;
                    return;
                }

                var empleos = this.dataSet1.Empleos;
                var id_empleo = empleos.Where(x => x.Empleo == empleo).Select(x => x.Id).FirstOrDefault();
                var t_empleos = this.dataSet1.Trabajadores_Empleos;                
                
                int found = t_empleos.AsEnumerable().Where(f => f.id_empleo == id_empleo).Count();

                if (found > 0)
                {
                    MessageBox.Show("El empleo ya esta cargado en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //this.trabajadores_EmpleosDataGridView.Rows.Remove(trabajadores_EmpleosDataGridView.CurrentRow);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en validar duplicidad de empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }*/
        }

        private void QuitarEmpleoToolStripButton_Click(object sender, EventArgs e)
        {
            trabajadores_EmpleosBindingSource.RemoveCurrent();
        }
    }
}
