namespace ManzantinesApp.Asientos
{
    partial class FrmTotales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rptDataSet = new ManzantinesApp.Data.RptDataSet();
            this.vv_totales_asientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vv_totales_asientosTableAdapter = new ManzantinesApp.Data.RptDataSetTableAdapters.vv_totales_asientosTableAdapter();
            this.tableAdapterManager = new ManzantinesApp.Data.RptDataSetTableAdapters.TableAdapterManager();
            this.AsientosPorPagarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TotalPagarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadPagadosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rptDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vv_totales_asientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsientosPorPagarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPagarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPagadosNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(215, 96);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "&OK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nº  de Asientos a Pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad Total por Pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cantidad de Pagados:";
            // 
            // rptDataSet
            // 
            this.rptDataSet.DataSetName = "RptDataSet";
            this.rptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vv_totales_asientosBindingSource
            // 
            this.vv_totales_asientosBindingSource.DataMember = "vv_totales_asientos";
            this.vv_totales_asientosBindingSource.DataSource = this.rptDataSet;
            // 
            // vv_totales_asientosTableAdapter
            // 
            this.vv_totales_asientosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ManzantinesApp.Data.RptDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AsientosPorPagarNumericUpDown
            // 
            this.AsientosPorPagarNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vv_totales_asientosBindingSource, "AsientosPorPagar", true));
            this.AsientosPorPagarNumericUpDown.Enabled = false;
            this.AsientosPorPagarNumericUpDown.Location = new System.Drawing.Point(171, 13);
            this.AsientosPorPagarNumericUpDown.Name = "AsientosPorPagarNumericUpDown";
            this.AsientosPorPagarNumericUpDown.ReadOnly = true;
            this.AsientosPorPagarNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.AsientosPorPagarNumericUpDown.TabIndex = 33;
            this.AsientosPorPagarNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AsientosPorPagarNumericUpDown.ThousandsSeparator = true;
            // 
            // TotalPagarNumericUpDown
            // 
            this.TotalPagarNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vv_totales_asientosBindingSource, "TotalPagar", true));
            this.TotalPagarNumericUpDown.DecimalPlaces = 2;
            this.TotalPagarNumericUpDown.Enabled = false;
            this.TotalPagarNumericUpDown.Location = new System.Drawing.Point(171, 39);
            this.TotalPagarNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.TotalPagarNumericUpDown.Name = "TotalPagarNumericUpDown";
            this.TotalPagarNumericUpDown.ReadOnly = true;
            this.TotalPagarNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TotalPagarNumericUpDown.TabIndex = 34;
            this.TotalPagarNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalPagarNumericUpDown.ThousandsSeparator = true;
            // 
            // CantidadPagadosNumericUpDown
            // 
            this.CantidadPagadosNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vv_totales_asientosBindingSource, "CantidadPagados", true));
            this.CantidadPagadosNumericUpDown.Enabled = false;
            this.CantidadPagadosNumericUpDown.Location = new System.Drawing.Point(171, 65);
            this.CantidadPagadosNumericUpDown.Name = "CantidadPagadosNumericUpDown";
            this.CantidadPagadosNumericUpDown.ReadOnly = true;
            this.CantidadPagadosNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadPagadosNumericUpDown.TabIndex = 35;
            this.CantidadPagadosNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CantidadPagadosNumericUpDown.ThousandsSeparator = true;
            // 
            // FrmTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 131);
            this.Controls.Add(this.CantidadPagadosNumericUpDown);
            this.Controls.Add(this.TotalPagarNumericUpDown);
            this.Controls.Add(this.AsientosPorPagarNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTotales";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Totales";
            this.Load += new System.EventHandler(this.FrmTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rptDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vv_totales_asientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsientosPorPagarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPagarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPagadosNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Data.RptDataSet rptDataSet;
        private System.Windows.Forms.BindingSource vv_totales_asientosBindingSource;
        private Data.RptDataSetTableAdapters.vv_totales_asientosTableAdapter vv_totales_asientosTableAdapter;
        private Data.RptDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown AsientosPorPagarNumericUpDown;
        private System.Windows.Forms.NumericUpDown TotalPagarNumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadPagadosNumericUpDown;
    }
}
