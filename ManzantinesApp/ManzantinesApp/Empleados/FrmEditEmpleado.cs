namespace ManzantinesApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;
    using Data;
    using ManzantinesApp.DBContext;

    public partial class FrmEditEmpleado : Form
    {
        #region Methods

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null) return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private bool ValidarCampos()
        {
            ErrorProvider error = new ErrorProvider();
            if (fincaComboBox.Text == "" && nroCasaComboBox.Text != "")
            {
                error.SetError(nroCasaComboBox, "No es posible asignar casa a trabajador sin su finca. Valide que haya seleccionado la finca.");
                nroCasaComboBox.Focus();
                return false;
            }

            if (trabajadores_EmpleosDataGridView.IsCurrentCellInEditMode)
            {
                error.SetError(trabajadores_EmpleosDataGridView, "Este control tiene cambios pendientes por validar");
                trabajadores_EmpleosDataGridView.Focus();
                return false;
            }

            return true;
        }

        private void Inicializar()
        {
            using (MazantinesEntities db = new MazantinesEntities())
            {
                this.id_empresaComboBox.ValueMember = "Id";
                this.id_empresaComboBox.DisplayMember = "Empresa";
                this.id_empresaComboBox.DataSource = db.Empresas.ToList();
                this.id_empresaComboBox.SelectedIndex = -1;

                this.fincaComboBox.ValueMember = "Id";
                this.fincaComboBox.DisplayMember = "Finca";
                this.fincaComboBox.DataSource = db.Fincas.ToList();
                this.fincaComboBox.SelectedIndex = -1;

                this.id_empleo.ValueMember = "Id";
                this.id_empleo.DisplayMember = "Empleo";
                this.id_empleo.DataSource = db.Empleos.ToList();

                if (miTrabajador != null)
                {
                    nro_empleadoTextBox.Text = miTrabajador.Nro_empleado;
                    cajaTextBox.Text = miTrabajador.Caja;
                    nombreTextBox.Text = miTrabajador.Nombre;
                    apellidosTextBox.Text = miTrabajador.Apellidos;
                    telefonoTextBox.Text = miTrabajador.Telefono;
                    cCCTextBox.Text = miTrabajador.CCC;
                    if (miTrabajador.foto2 != null) foto2PictureBox.Image = (Bitmap)new ImageConverter().ConvertFrom(miTrabajador.foto2);
                    if(miTrabajador.id_empresa != null) id_empresaComboBox.SelectedValue = miTrabajador.id_empresa;
                    if (miTrabajador.id_casa != null)
                    {
                        nroCasaComboBox.SelectedValue = miTrabajador.id_casa;
                        int? selected_finca = db.Casas.Where(c => c.Id == miTrabajador.id_casa).Select(f => f.id_finca).FirstOrDefault();
                        this.fincaComboBox.SelectedValue = selected_finca;
                    }

                    List<Trabajadores_Empleos> empleos = db.Trabajadores_Empleos.Where(e => e.id_trabajador == miTrabajador.Id).ToList();
                    foreach (var item in empleos)
                    {
                        this.trabajadores_EmpleosDataGridView.Rows.Add(item.Id, item.id_trabajador, item.id_empleo);
                    }
                }
            }
        }
        #endregion

        #region Properties
        public Trabajadores miTrabajador { get; set; } = null;
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
            Inicializar();    
        }        

        private void fincaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.fincaComboBox.Text))
            {
                this.nroCasaComboBox.DataSource = null;
            }
            else
            {
                using (MazantinesEntities db = new MazantinesEntities())
                {
                    this.nroCasaComboBox.ValueMember = "Id";
                    this.nroCasaComboBox.DisplayMember = "NroCasa";
                    this.nroCasaComboBox.DataSource = db.Casas.Where(c => c.id_finca == (int)fincaComboBox.SelectedValue).ToList();
                    this.nroCasaComboBox.SelectedIndex = -1;
                }
            }
        }

        private void fincaComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.fincaComboBox.Text))
            {
                this.nroCasaComboBox.DataSource = null;
            }
        }

        private void QuitarEmpleoToolStripButton_Click_1(object sender, EventArgs e)
        {           
            try
            {
                int index = this.trabajadores_EmpleosDataGridView.CurrentRow.Index;
                if (index < 0) return;
                if (this.trabajadores_EmpleosDataGridView.IsCurrentCellInEditMode) return;
                if (this.trabajadores_EmpleosDataGridView.IsCurrentCellDirty) return;
                if (this.trabajadores_EmpleosDataGridView.IsCurrentRowDirty) return;
                this.trabajadores_EmpleosDataGridView.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de borrado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void GuardarToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                using (MazantinesEntities db = new MazantinesEntities())
                {
                    int? id_casa = null;
                    int? id_empresa = null;

                    if (nroCasaComboBox.SelectedValue != null)
                        id_casa = (int)nroCasaComboBox.SelectedValue;

                    if (id_empresaComboBox.SelectedValue != null)
                        id_empresa = (int)id_empresaComboBox.SelectedValue;

                    Trabajadores trabajador = new Trabajadores()
                    {
                        Apellidos = apellidosTextBox.Text.Trim(),
                        Caja = cajaTextBox.Text.Trim(),
                        CCC = cCCTextBox.Text.Trim(),
                        foto2 = ImageToByteArray(foto2PictureBox.Image),
                        id_casa = id_casa,
                        id_empresa = id_empresa,
                        Nombre = nombreTextBox.Text.Trim(),
                        Nro_empleado = nro_empleadoTextBox.Text.Trim(),
                        Telefono = telefonoTextBox.Text.Trim(),
                    };

                    if (miTrabajador != null)
                        db.Trabajadores_Empleos.RemoveRange(db.Trabajadores_Empleos.Where(x => x.id_trabajador == miTrabajador.Id));

                    if (trabajadores_EmpleosDataGridView.RowCount > 0)
                    {
                        foreach (DataGridViewRow row in trabajadores_EmpleosDataGridView.Rows)
                        {
                            if (row.Cells["id_empleo"].Value == null) continue;

                            var empleos = new Trabajadores_Empleos();
                            empleos.id_empleo = (int)row.Cells["id_empleo"].Value;

                            if (row.Cells["Id"].Value != null)
                                empleos.Id = (int)row.Cells["Id"].Value;
                            if (row.Cells["id_trabajador"].Value != null)
                                empleos.id_trabajador = (int)row.Cells["id_trabajador"].Value;

                            trabajador.Trabajadores_Empleos.Add(empleos);
                        }
                    }
                    else
                    {
                        trabajador.Trabajadores_Empleos = null;
                    }

                    if (miTrabajador == null)
                    {
                        db.Trabajadores.Add(trabajador);
                        db.SaveChanges();
                    }
                    else
                    {
                        trabajador.Id = miTrabajador.Id;
                        db.Trabajadores.Add(trabajador);
                        db.Entry(trabajador).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }

                    this.UpdateList = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitarFototoolStripButton_Click_1(object sender, EventArgs e)
        {
            foto2PictureBox.Image = null;
        }

        private void foto2PictureBox_Click_1(object sender, EventArgs e)
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
