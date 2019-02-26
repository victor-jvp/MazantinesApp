﻿namespace ManzantinesApp
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
            this.fincasTableAdapter.Fill(this.dataSet1.Fincas);
            this.trabajadoresTableAdapter.Fill(this.dataSet1.Trabajadores);
            this.trabajadores_EmpleosTableAdapter.Fill(this.dataSet1.Trabajadores_Empleos);
            this.encargadosTableAdapter.Fill(this.dataSet1.Encargados);
            this.empresasTableAdapter.Fill(this.dataSet1.Empresas);
            this.empleosTableAdapter.Fill(this.dataSet1.Empleos);            

            if(miTrabajador == null)
            {
                trabajadoresBindingSource.AddNew();
            }
            else
            {
                this.trabajadoresBindingSource.Position = trabajadoresBindingSource.Find("Id", miTrabajador.Id);
            }

            this.fincaComboBox.SelectedIndex = -1;
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

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureOpenFileDialog.Filter = "jpg|*.jpg|png|*.png";
            PictureOpenFileDialog.ValidateNames = true;
            PictureOpenFileDialog.Multiselect = false;

            if (PictureOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoTextBox.Text = PictureOpenFileDialog.SafeFileName;
                pictureBox1.Image = Image.FromFile(PictureOpenFileDialog.FileName);

                
            }
        }

        private void QuitarFototoolStripButton_Click(object sender, EventArgs e)
        {
            fotoTextBox.Text = string.Empty;
            pictureBox1.ImageLocation = string.Empty;
        }
    }
}
