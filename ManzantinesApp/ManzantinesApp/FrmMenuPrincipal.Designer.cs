namespace ManzantinesApp
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fincasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Casa01Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.datosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "&Archivos";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.soporteToolStripMenuItem.Text = "&Soporte";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "&Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fincasToolStripMenuItem,
            this.casasToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.empleoToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "&Datos";
            // 
            // fincasToolStripMenuItem
            // 
            this.fincasToolStripMenuItem.Name = "fincasToolStripMenuItem";
            this.fincasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fincasToolStripMenuItem.Text = "&Fincas";
            this.fincasToolStripMenuItem.Click += new System.EventHandler(this.fincasToolStripMenuItem_Click);
            // 
            // casasToolStripMenuItem
            // 
            this.casasToolStripMenuItem.Name = "casasToolStripMenuItem";
            this.casasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.casasToolStripMenuItem.Text = "&Casas";
            this.casasToolStripMenuItem.Click += new System.EventHandler(this.casasToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.empresaToolStripMenuItem.Text = "&Empresas";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // empleoToolStripMenuItem
            // 
            this.empleoToolStripMenuItem.Name = "empleoToolStripMenuItem";
            this.empleoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.empleoToolStripMenuItem.Text = "E&mpleos";
            this.empleoToolStripMenuItem.Click += new System.EventHandler(this.empleoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Casa01Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 515);
            this.panel1.TabIndex = 3;
            // 
            // Casa01Button
            // 
            this.Casa01Button.Image = ((System.Drawing.Image)(resources.GetObject("Casa01Button.Image")));
            this.Casa01Button.Location = new System.Drawing.Point(95, 262);
            this.Casa01Button.Name = "Casa01Button";
            this.Casa01Button.Size = new System.Drawing.Size(30, 28);
            this.Casa01Button.TabIndex = 1;
            this.Casa01Button.UseVisualStyleBackColor = true;
            this.Casa01Button.Click += new System.EventHandler(this.Casa01Button_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal - Mazantines";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Casa01Button;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fincasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleoToolStripMenuItem;
    }
}

