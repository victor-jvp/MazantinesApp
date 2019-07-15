namespace ManzantinesApp.Liquidaciones
{
    partial class FrmKilogramos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKilogramos));
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.liquidacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FrutaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FincaComboBox = new System.Windows.Forms.ComboBox();
            this.VariedadTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(112, 41);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.FechaDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidacionesBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(342, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // liquidacionesBindingNavigatorSaveItem
            // 
            this.liquidacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("liquidacionesBindingNavigatorSaveItem.Image")));
            this.liquidacionesBindingNavigatorSaveItem.Name = "liquidacionesBindingNavigatorSaveItem";
            this.liquidacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.liquidacionesBindingNavigatorSaveItem.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FrutaComboBox
            // 
            this.FrutaComboBox.FormattingEnabled = true;
            this.FrutaComboBox.Location = new System.Drawing.Point(112, 68);
            this.FrutaComboBox.Name = "FrutaComboBox";
            this.FrutaComboBox.Size = new System.Drawing.Size(169, 21);
            this.FrutaComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Variedad:";
            // 
            // totalesNumericUpDown
            // 
            this.totalesNumericUpDown.DecimalPlaces = 2;
            this.totalesNumericUpDown.Location = new System.Drawing.Point(112, 122);
            this.totalesNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalesNumericUpDown.Name = "totalesNumericUpDown";
            this.totalesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.totalesNumericUpDown.TabIndex = 22;
            this.totalesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalesNumericUpDown.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kilogramos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Finca:";
            // 
            // FincaComboBox
            // 
            this.FincaComboBox.FormattingEnabled = true;
            this.FincaComboBox.Location = new System.Drawing.Point(112, 148);
            this.FincaComboBox.Name = "FincaComboBox";
            this.FincaComboBox.Size = new System.Drawing.Size(169, 21);
            this.FincaComboBox.TabIndex = 25;
            // 
            // VariedadTextBox
            // 
            this.VariedadTextBox.Location = new System.Drawing.Point(112, 96);
            this.VariedadTextBox.Name = "VariedadTextBox";
            this.VariedadTextBox.Size = new System.Drawing.Size(169, 20);
            this.VariedadTextBox.TabIndex = 26;
            // 
            // FrmKilogramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 193);
            this.Controls.Add(this.VariedadTextBox);
            this.Controls.Add(this.FincaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalesNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FrutaComboBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKilogramos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kilogramos";
            this.Load += new System.EventHandler(this.FrmKilogramos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton liquidacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox FrutaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown totalesNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FincaComboBox;
        private System.Windows.Forms.TextBox VariedadTextBox;
    }
}