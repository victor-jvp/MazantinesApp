namespace ManzantinesApp.Classes
{
    using CrystalDecisions.CrystalReports.Engine;
    using ManzantinesApp.Reports;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Reflection;
    using System.Windows.Forms;

    public class Reports
    {
        public static void VistaPreliminar(ReportDocument CrystalReport, DataTable dt)
        {
            
            try
            {
                FrmPreviewCrystal frmPreviewCrystal = new FrmPreviewCrystal();
                frmPreviewCrystal.ReporteCrystal = CrystalReport;

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                frmPreviewCrystal.ReporteCrystal.SetDataSource(ds);
                frmPreviewCrystal.Show();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error en Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
