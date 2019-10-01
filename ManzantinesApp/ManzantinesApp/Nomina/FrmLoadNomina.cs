﻿

namespace ManzantinesApp.Nomina
{
    using DBContext;
    using ManzantinesApp.Classes;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FrmLoadNomina : Form
    {
        private void Inicializar()
        {
            try
            {
                using (var db = new DBContext.MazantinesEntities())
                {
                    var result = db.NominasCab.Select(n => new {
                        id_cab = n.id_cab,
                        anio = n.anio,
                        semana = n.semana,
                        encargado = n.Encargados.Encargado,
                        estado = n.status
                    }).OrderByDescending(f => f.anio).ThenByDescending(f => f.semana).ToList();

                    NominasBindingSource.DataSource = result;
                    NominasDataGridView.DataSource = NominasBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }            
        }

        private int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void NuevaNomina()
        {
            try
            {
                FrmNomina miNomina = new FrmNomina();
                miNomina.id_nomina = null;
                miNomina.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void EditNomina()
        {
            try
            {
                int id = (int)this.NominasDataGridView.CurrentRow.Cells["id"].Value;
                FrmNomina miNomina = new FrmNomina();
                miNomina.id_nomina = id;
                miNomina.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //private void filterNomina()
        //{
        //    try
        //    {
        //        int? semana = (int?)SemanaComboBox.ComboBox.SelectedValue;
        //        int? anio = (int?)AnioComboBox.ComboBox.SelectedValue;
        //        string filter = "";

        //        NominasBindingSource.RemoveFilter();

        //        if (anio != null)
        //        {
        //            filter += $"anio = {Convert.ToInt32(anio.ToString())}";
        //        }
        //        if (semana != null)
        //        {
        //            if (!string.IsNullOrEmpty(filter)) filter += " AND ";
        //            filter += $"semana = {Convert.ToInt32(semana.ToString())}";
        //        }

        //        if (!string.IsNullOrEmpty(filter))
        //        {
        //            NominasBindingSource.Filter = filter;
        //            NominasDataGridView.DataSource = NominasBindingSource;
        //        }
        //    }
        //    catch (Exception)
        //    {
                
        //    }
        //}

        public FrmLoadNomina()
        {
            InitializeComponent();
        }

        private void FrmLoadNomina_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void NuevaToolStripButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            NuevaNomina();
            this.Enabled = true;
        }

        private void CargarToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.NominasDataGridView.CurrentRow == null || this.NominasDataGridView.CurrentRow.Index == -1) return;
            this.Enabled = false;
            EditNomina();
            this.Enabled = true;
        }
    }
}
