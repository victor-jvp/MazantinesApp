namespace ManzantinesApp
{
    partial class FrmAddProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label nroCuentaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label bancoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProveedor));
            this.proveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.proveedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cifTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.nroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.proveedoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cifLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            nroCuentaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).BeginInit();
            this.proveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(62, 31);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(26, 13);
            cifLabel.TabIndex = 0;
            cifLabel.Text = "CIF:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(15, 57);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 2;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // nroCuentaLabel
            // 
            nroCuentaLabel.AutoSize = true;
            nroCuentaLabel.Location = new System.Drawing.Point(21, 109);
            nroCuentaLabel.Name = "nroCuentaLabel";
            nroCuentaLabel.Size = new System.Drawing.Size(67, 13);
            nroCuentaLabel.TabIndex = 6;
            nroCuentaLabel.Text = "Nro. Cuenta:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(36, 135);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Teléfono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(53, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(47, 83);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 4;
            bancoLabel.Text = "Banco:";
            // 
            // proveedoresBindingNavigator
            // 
            this.proveedoresBindingNavigator.AddNewItem = null;
            this.proveedoresBindingNavigator.BindingSource = this.proveedoresBindingSource;
            this.proveedoresBindingNavigator.CountItem = null;
            this.proveedoresBindingNavigator.DeleteItem = null;
            this.proveedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.proveedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedoresBindingNavigator.MoveFirstItem = null;
            this.proveedoresBindingNavigator.MoveLastItem = null;
            this.proveedoresBindingNavigator.MoveNextItem = null;
            this.proveedoresBindingNavigator.MovePreviousItem = null;
            this.proveedoresBindingNavigator.Name = "proveedoresBindingNavigator";
            this.proveedoresBindingNavigator.PositionItem = null;
            this.proveedoresBindingNavigator.Size = new System.Drawing.Size(406, 25);
            this.proveedoresBindingNavigator.TabIndex = 12;
            this.proveedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingNavigatorSaveItem
            // 
            this.proveedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresBindingNavigatorSaveItem.Image")));
            this.proveedoresBindingNavigatorSaveItem.Name = "proveedoresBindingNavigatorSaveItem";
            this.proveedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.proveedoresBindingNavigatorSaveItem.Text = "&Guardar";
            this.proveedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.proveedoresBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Cif", true));
            this.cifTextBox.Location = new System.Drawing.Point(94, 28);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(100, 20);
            this.cifTextBox.TabIndex = 1;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(94, 54);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(268, 20);
            this.razonSocialTextBox.TabIndex = 3;
            // 
            // nroCuentaTextBox
            // 
            this.nroCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NroCuenta", true));
            this.nroCuentaTextBox.Location = new System.Drawing.Point(94, 106);
            this.nroCuentaTextBox.Name = "nroCuentaTextBox";
            this.nroCuentaTextBox.Size = new System.Drawing.Size(160, 20);
            this.nroCuentaTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(94, 132);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(160, 20);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(94, 158);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasasTableAdapter = null;
            this.tableAdapterManager.EmpleosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.EncargadosTableAdapter = null;
            this.tableAdapterManager.FincasTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.Trabajadores_EmpleosTableAdapter = null;
            this.tableAdapterManager.TrabajadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(94, 80);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(160, 20);
            this.bancoTextBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(nroCuentaLabel);
            this.Controls.Add(this.nroCuentaTextBox);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(cifLabel);
            this.Controls.Add(this.cifTextBox);
            this.Controls.Add(this.proveedoresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Proveedor";
            this.Load += new System.EventHandler(this.FrmAddProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).EndInit();
            this.proveedoresBindingNavigator.ResumeLayout(false);
            this.proveedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Data.DataSet1TableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private Data.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton proveedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cifTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox nroCuentaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}