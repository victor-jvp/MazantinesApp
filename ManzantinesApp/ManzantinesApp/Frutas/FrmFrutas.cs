namespace ManzantinesApp.Frutas
{
    using ManzantinesApp.DBContext;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class FrmFrutas : Form
    {
        #region Methods

        private static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void Initialize()
        {
            using (var db = new MazantinesEntities())
            {
                var misFrutas = db.Frutas.
                    Select(f => new { f.Id, f.Fruta, f.DeletedAt }).
                    Where(f => f.DeletedAt == null).
                    OrderBy(f => f.Fruta).ToList();
                FrutasDataGridView.DataSource = ToDataTable(misFrutas);
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
            FrmEditFrutas miForm = new FrmEditFrutas
            {
                miFruta = new Frutas()
            };
            miForm.ShowDialog(this);

            if (miForm.doRefresh)
            {
                Initialize();
            }

            this.Enabled = true;
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (FrutasDataGridView.CurrentRow == null)
            {
                return;
            }

            this.Enabled = false;
            int id = (int)FrutasDataGridView.CurrentRow.Cells["Id"].Value;
            FrmEditFrutas miForm = new FrmEditFrutas();
            using (var db = new MazantinesEntities())
            {
                miForm.miFruta = db.Frutas.Where(f => f.Id == id).FirstOrDefault();
                miForm.ShowDialog(this);
            }

            if (miForm.doRefresh)
            {
                Initialize();
            }

            this.Enabled = true;
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (FrutasDataGridView.CurrentRow == null)
            {
                return;
            }

            DialogResult mensaje = MessageBox.Show(
                "Confirme eliminar el registro.",
                "Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (mensaje == DialogResult.No)
            {
                return;
            }

            using (var db = new MazantinesEntities())
            {
                int id = Convert.ToInt32(FrutasDataGridView.CurrentRow.Cells["Id"].Value);
                var fruta = db.Frutas.Where(f => f.Id == id).First();
                if (fruta != null)
                {
                    fruta.DeletedAt = DateTime.Now;
                    db.Frutas.Add(fruta);
                    db.Entry(fruta).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Initialize();
                }
            }
        }
    }
}
