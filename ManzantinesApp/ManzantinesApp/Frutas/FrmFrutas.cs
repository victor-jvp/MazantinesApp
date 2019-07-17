namespace ManzantinesApp.Frutas
{
    using ManzantinesApp.DBContext;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmFrutas : Form
    {
        #region Methods

        private void Initialize()
        {
            using (var db = new MazantinesEntities())
            {
                var misFrutas = db.Frutas.
                    Select(f => new { f.Id, f.Fruta, f.DeletedAt}).
                    Where(f => f.DeletedAt == null).
                    OrderBy(f => f.Fruta).ToList();
                FrutasDataGridView.DataSource = misFrutas;
            }
        }

        #endregion
        public FrmFrutas()
        {
            InitializeComponent();
        }

        private void FrmFrutas_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            int id = (int)FrutasDataGridView.CurrentRow.Cells["Id"].Value;
            FrmEditFrutas miForm = new FrmEditFrutas();
            miForm.miFruta = new Frutas();
            miForm.ShowDialog(this);

            if (miForm.doRefresh) Initialize();

            this.Enabled = true;
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (FrutasDataGridView.CurrentRow == null) return;

            this.Enabled = false;
            int id = (int)FrutasDataGridView.CurrentRow.Cells["Id"].Value;
            FrmEditFrutas miForm = new FrmEditFrutas();
            using (var db = new MazantinesEntities())
            {
                miForm.miFruta = db.Frutas.Where(f => f.Id == id).FirstOrDefault();
                miForm.ShowDialog(this);
            }
            
            if (miForm.doRefresh) Initialize();

            this.Enabled = true;
        }
    }
}
