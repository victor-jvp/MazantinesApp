namespace ManzantinesApp.Frutas
{
    using DBContext;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FrmEditFrutas : Form
    {
        public DBContext.Frutas miFruta { get; set; }
        public bool doRefresh { get; set; }

        private void Inicializar()
        {
            if (miFruta.Id > 0)
            {
                FrutaTextBox.Text = miFruta.Fruta;
                BindingSource bindingSource = new BindingSource();
                using (var db = new MazantinesEntities())
                {
                    bindingSource.DataSource = db.Frutas_variedades.Where(f => f.id_fruta == miFruta.Id).ToList();
                }
                VariedadDataGridView.DataSource = bindingSource;
            }
        }

        public FrmEditFrutas()
        {
            InitializeComponent();
        }

        private void FrmEditFrutas_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                using (var db = new MazantinesEntities())
                {
                    var newFruta = db.Frutas.Where(f => f.Id == miFruta.Id).FirstOrDefault();
                    newFruta.Fruta = FrutaTextBox.Text;

                    var variedades_old = db.Frutas_variedades.Where(f => f.id_fruta == newFruta.Id).ToList();
                    db.Frutas_variedades.RemoveRange(variedades_old);

                    newFruta.Frutas_variedades = new List<Frutas_variedades>();

                    if (VariedadDataGridView.RowCount > 0)
                    {
                        foreach (DataGridViewRow row in VariedadDataGridView.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                Frutas_variedades miVariedad = new Frutas_variedades()
                                {
                                    DeletedAt = null,
                                    Variedad = row.Cells["Variedad"].Value.ToString()
                                };
                                newFruta.Frutas_variedades.Add(miVariedad);
                            }
                        }
                    }

                    db.Frutas.Add(newFruta);

                    if (newFruta.Id > 0)
                    {
                        
                        db.Entry(newFruta).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        db.Frutas.Add(newFruta);
                    }
                    
                    db.SaveChanges();
                    MessageBox.Show(
                        "Proceso realizado correctamente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                    doRefresh = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
