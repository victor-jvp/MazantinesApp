namespace ManzantinesApp
{

    using ManzantinesApp.Data;
    using System;
    using System.Windows.Forms;

    public partial class FrmEditProveedor : Form
    {


        #region Properties
        public DataSet1.ProveedoresRow miProveedor { get; set; } = null;
        public bool UpdateList { get; set; } = false;
        #endregion

        public FrmEditProveedor()
        {
            InitializeComponent();
        }

        private void FrmEditProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
