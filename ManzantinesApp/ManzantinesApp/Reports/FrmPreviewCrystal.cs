namespace ManzantinesApp.Reports
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;
    using System;
    using System.Configuration;
    using System.Windows.Forms;

    public partial class FrmPreviewCrystal : Form
    {
        #region Attributes
        private ConnectionInfo crConnectionInfo = new ConnectionInfo();
        private TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
        #endregion

        #region Properties
        public ReportDocument ReporteCrystal { get; set; }
        #endregion


        public FrmPreviewCrystal()
        {
            InitializeComponent();
        }

        private void FrmPreviewCrystal_Load(object sender, EventArgs e)
        {
            conexion();
            crystalReportViewer1.ReportSource = ReporteCrystal;
        }

        private void conexion()
        {
            // Parametros de la conexion
            string conString = ConfigurationManager.ConnectionStrings["ManzantinesApp.Properties.Settings.Database1ConnectionString"].ToString();
            var array1 = conString.Split('=');
            var SERVER = array1[1].Split(';');
            var DB = array1[2].Split(';');
            //var USER = array1[4].Split(';');
            //string PW = array1[5];
            {
                var withBlock = crConnectionInfo;
                withBlock.IntegratedSecurity = true;
                withBlock.ServerName = SERVER[0];
                withBlock.DatabaseName = DB[0];
                /*withBlock.UserID = USER[0];
                withBlock.Password = PW;*/
            }

            // MsgBox(crConnectionInfo.DatabaseName)

            foreach (Table CrTable in ReporteCrystal.Database.Tables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
        }
    }
}
