﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManzantinesApp
{
    public partial class FrmAddProveedor : Form
    {
        #region Properties
        public bool UpdateList { get; set; } = false;
        #endregion

        public FrmAddProveedor()
        {
            InitializeComponent();
        }

        private void FrmAddProveedor_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Fill(this.dataSet1.Proveedores);
            this.proveedoresBindingSource.AddNew();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                this.Validate();
                this.proveedoresBindingSource.EndEdit();
                this.proveedoresTableAdapter.Update(this.dataSet1.Proveedores);
                this.UpdateList = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Error en Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();

            var control = new TextBox();
            control = cifTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = razonSocialTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = bancoTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = nroCuentaTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = telefonoTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            control = emailTextBox;
            if (string.IsNullOrEmpty(control.Text.Trim()))
            {
                errorProvider1.SetError(control, "Este campo es requerido");
                control.Focus();
                return false;
            }

            return true;
        }
    }
}
