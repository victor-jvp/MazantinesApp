namespace ManzantinesApp
{
    partial class FrmEditProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditProveedor));
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label nroCuentaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            this.dataSet1 = new ManzantinesApp.Data.DataSet1();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new ManzantinesApp.Data.DataSet1TableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.DataSet1TableAdapters.TableAdapterManager();
            this.proveedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.proveedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cifTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.nroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            cifLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            bancoLabel = new System.Windows.Forms.Label();
            nroCuentaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).BeginInit();
            this.proveedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dataSet1;
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
            this.proveedoresBindingNavigator.TabIndex = 0;
            this.proveedoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // proveedoresBindingNavigatorSaveItem
            // 
            this.proveedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresBindingNavigatorSaveItem.Image")));
            this.proveedoresBindingNavigatorSaveItem.Name = "proveedoresBindingNavigatorSaveItem";
            this.proveedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.proveedoresBindingNavigatorSaveItem.Text = "&Guardar";
            this.proveedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.ProveedoresBindingNavigatorSaveItem_Click);
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(62, 31);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(26, 13);
            cifLabel.TabIndex = 1;
            cifLabel.Text = "CIF:";
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Cif", true));
            this.cifTextBox.Location = new System.Drawing.Point(94, 28);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(100, 20);
            this.cifTextBox.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(15, 57);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 3;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(94, 54);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(268, 20);
            this.razonSocialTextBox.TabIndex = 4;
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Location = new System.Drawing.Point(47, 83);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(41, 13);
            bancoLabel.TabIndex = 5;
            bancoLabel.Text = "Banco:";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Banco", true));
            this.bancoTextBox.Location = new System.Drawing.Point(94, 80);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(160, 20);
            this.bancoTextBox.TabIndex = 6;
            // 
            // nroCuentaLabel
            // 
            nroCuentaLabel.AutoSize = true;
            nroCuentaLabel.Location = new System.Drawing.Point(21, 109);
            nroCuentaLabel.Name = "nroCuentaLabel";
            nroCuentaLabel.Size = new System.Drawing.Size(67, 13);
            nroCuentaLabel.TabIndex = 7;
            nroCuentaLabel.Text = "Nro. Cuenta:";
            // 
            // nroCuentaTextBox
            // 
            this.nroCuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NroCuenta", true));
            this.nroCuentaTextBox.Location = new System.Drawing.Point(94, 106);
            this.nroCuentaTextBox.Name = "nroCuentaTextBox";
            this.nroCuentaTextBox.Size = new System.Drawing.Size(160, 20);
            this.nroCuentaTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(36, 135);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(94, 132);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(160, 20);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(53, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(94, 158);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(237, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(262, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 14;
            // 
            // FrmEditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 198);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(nroCuentaLabel);
            this.Controls.Add(this.nroCuentaTextBox);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(cifLabel);
            this.Controls.Add(this.cifTextBox);
            this.Controls.Add(this.proveedoresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 232);
            this.Name = "FrmEditProveedor";
            this.Text = "Modificar Proveedor";
            this.Load += new System.EventHandler(this.FrmEditProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingNavigator)).EndInit();
            this.proveedoresBindingNavigator.ResumeLayout(false);
            this.proveedoresBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox cifTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.TextBox nroCuentaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox idTextBox;
    }
}