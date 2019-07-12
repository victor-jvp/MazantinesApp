namespace ManzantinesApp.Nomina
{
    using ManzantinesApp.Classes;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Windows.Forms;
    using System.Linq;
    using ManzantinesApp.DBContext;
    using System.Drawing;
    using System.Reflection;

    public partial class FrmNomina : Form
    {

        #region Properties

        List<vv_nominas> nominas = null;

        #endregion

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

        private void Inicializar()
        {
            var anio = DateTime.Now.Year;
            LoadCombos(anio);

            NominaDataGridView.DataSource = null;

            ModoEdicionNominaFalse();
        }

        private void LoadCombos(int anio)
        {
            AnioComboBox.ComboBox.DataSource = Anios.GetAnios(anio);
            AnioComboBox.ComboBox.DisplayMember = "Value";
            AnioComboBox.ComboBox.ValueMember = "Value";
            AnioComboBox.ComboBox.SelectedValue = anio;

            SemanaComboBox.ComboBox.DataSource = Semanas.GetSemanas(anio);
            SemanaComboBox.ComboBox.DisplayMember = "Value";
            SemanaComboBox.ComboBox.ValueMember = "Value";
            SemanaComboBox.ComboBox.SelectedValue = GetWeekNumber();

            EncargadoComboBox.ComboBox.DataSource = encargadosTableAdapter1.GetData();
            EncargadoComboBox.ComboBox.DisplayMember = "Encargado";
            EncargadoComboBox.ComboBox.ValueMember = "Id";
            EncargadoComboBox.ComboBox.SelectedIndex = -1;
        }

        private int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void CargarNomina(int anio, int semana, int encargado = 0)
        {
            try
            {
                if (anio <= 0 || (semana <= 0 && semana > 53))
                {
                    MessageBox.Show(
                        "Error en los datos suministrador para la Nomina",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                //Validar si existe una nomina con los parametros indicados
                nominas = null;
                using (MazantinesEntities db = new MazantinesEntities())
                {
                    if(encargado == 0)
                    {
                        nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana && f.id_encargado == null).OrderBy(f => f.caja).ToList();
                    }
                    else
                    {
                        nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana && f.id_encargado == encargado).OrderBy(f => f.caja).ToList();
                    }                    
                }

                if(nominas == null || nominas.Count <= 0)
                {
                    List<vv_nomina_trabajadores> trabajadores = null;
                    using (MazantinesEntities db = new MazantinesEntities())
                    {
                        NominasCab cab = new NominasCab()
                        {
                            semana = semana,
                            anio = anio,
                            status = "A"
                        };

                        if (encargado != 0)
                        {
                            cab.id_encargado = encargado;
                            trabajadores = db.vv_nomina_trabajadores.Where(t => t.id_encargado == encargado).ToList();
                        }
                        else
                        {
                            trabajadores = db.vv_nomina_trabajadores.Where(t=> t.id_encargado == null).ToList();
                        }

                        if (trabajadores.Count == 0)
                        {
                            MessageBox.Show(
                                "No existen trabajadores asociados al encargado seleccionado.",
                                "Error en carga de Nómina",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        foreach (vv_nomina_trabajadores row in trabajadores)
                        {
                            cab.NominasDet.Add(new NominasDet
                            {
                                id_empleado = row.id,
                                lunD = 1,
                                lunH = 0,
                                marD = 1,
                                marH = 0,
                                mieD = 1,
                                mieH = 0,
                                jueD = 1,
                                jueH = 0,
                                vieD = 1,
                                vieH = 0,
                                sabD = 1,
                                sabH = 0,
                                domD = 1,
                                domH = 0,
                                valorD = row.valorD,
                                valorH = row.valorH,
                                pagado = false
                            });
                        }
                        db.NominasCab.Add(cab);
                        db.SaveChanges();

                        if (encargado == 0)
                        {
                            nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana && f.id_encargado == null).OrderBy(f => f.caja).ToList();
                        }
                        else
                        {
                            nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana && f.id_encargado == encargado).OrderBy(f => f.caja).ToList();
                        }
                    }
                }
                if (NominaDataGridView.Columns["pagado"] == null)
                {
                    NominaDataGridView.Columns.Add(new DataGridViewCheckBoxColumn() { Name = "pagado", HeaderText = "Pagado", TrueValue = true, FalseValue = false, DataPropertyName = "pagado" });
                }
                
                NominaDataGridView.DataSource = nominas;
                FormatColumns();
                CalcularTotales();
                ModoEdicionNominaTrue();

                //Validar si la nomina esta cerrada
                if (nominas[0].status == "C")
                {
                    MessageBox.Show(
                        "La Nomina seleccionada esta Cerrada, no es posible modificar valores. Se permite marcar/desmarcar pago.",
                        "Nomina Cerrada ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    DeshabilitarGrid();
                    ModoNominaCerrada();
                }
                else
                {
                    HabilitarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en carga de Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void GuardarNomina()
        {
            try
            {
                using (MazantinesEntities db = new MazantinesEntities())
                {
                    foreach (vv_nominas nomina in nominas)
                    {
                        NominasDet miNomina = db.NominasDet.Where(d => d.id_det == nomina.id_det).FirstOrDefault();
                        //miNomina.id_cab = nomina.id_cab;
                        //miNomina.id_det = nomina.id_det;
                        //miNomina.id_empleado = nomina.id_empleado;
                        //miNomina.valorD = nomina.valorD;
                        //miNomina.valorH = nomina.valorH;
                        miNomina.lunD = nomina.lunD;
                        miNomina.lunH = nomina.lunH;
                        miNomina.marD = nomina.marD;
                        miNomina.marH = nomina.marH;
                        miNomina.mieD = nomina.mieD;
                        miNomina.mieH = nomina.mieH;
                        miNomina.jueD = nomina.jueD;
                        miNomina.jueH = nomina.jueH;
                        miNomina.vieD = nomina.vieD;
                        miNomina.vieH = nomina.vieH;
                        miNomina.sabD = nomina.sabD;
                        miNomina.sabH = nomina.sabH;
                        miNomina.domD = nomina.domD;
                        miNomina.domH = nomina.domH;
                        miNomina.pagado = nomina.pagado;
                        db.NominasDet.Add(miNomina);
                        db.Entry(miNomina).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }

                LimpiarNominaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Guardar Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarNominaGrid()
        {
            NominaDataGridView.DataSource = null;
            NominaDataGridView.Columns.Clear();

            TotalesDataGridView.DataSource = null;
        }

        private void CerrarNomina()
        {
            try
            {
                GuardarNomina();

                int cab_id = (int)nominas[0].id_cab;

                using (MazantinesEntities db = new MazantinesEntities())
                {
                    var cab = db.NominasCab.Where(c => c.id_cab == cab_id).First();
                    cab.status = "C";
                    db.NominasCab.Add(cab);
                    db.Entry(cab).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                ModoNominaCerrada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Cerrar Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void FormatColumns()
        {
            if(NominaDataGridView.Columns["totalD"] == null)
            {
                NominaDataGridView.Columns.Add("totalD", "Dias");
                NominaDataGridView.Columns.Add("totalH", "Horas");
            }            

            NominaDataGridView.Columns["anio"].Visible = false;
            NominaDataGridView.Columns["semana"].Visible = false;
            NominaDataGridView.Columns["status"].Visible = false;
            NominaDataGridView.Columns["id_encargado"].Visible = false;
            NominaDataGridView.Columns["nro_empleado"].HeaderText = "Nro. Empleado";
            NominaDataGridView.Columns["nro_empleado"].ReadOnly = true;
            NominaDataGridView.Columns["nro_empleado"].DefaultCellStyle.BackColor = Color.LightGray;
            NominaDataGridView.Columns["caja"].HeaderText = "Nro. Caja";
            NominaDataGridView.Columns["caja"].ReadOnly = true;
            NominaDataGridView.Columns["caja"].DefaultCellStyle.BackColor = Color.LightGray;
            NominaDataGridView.Columns["trabajador"].HeaderText = "Empleado";
            NominaDataGridView.Columns["trabajador"].DefaultCellStyle.BackColor = Color.LightGray;
            NominaDataGridView.Columns["trabajador"].ReadOnly = true;
            NominaDataGridView.Columns["id_empleo"].Visible = false;
            NominaDataGridView.Columns["id_det"].Visible = false;
            NominaDataGridView.Columns["id_cab"].Visible = false;
            NominaDataGridView.Columns["id_empleado"].Visible = false;
            NominaDataGridView.Columns["valorD"].Visible = false;
            NominaDataGridView.Columns["valorH"].Visible = false;
            NominaDataGridView.Columns["lunD"].HeaderText = "Dia";
            NominaDataGridView.Columns["lunH"].HeaderText = "Extra";
            NominaDataGridView.Columns["lunD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["lunD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["lunH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["lunH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["marD"].HeaderText = "Dia";
            NominaDataGridView.Columns["marH"].HeaderText = "Extra";
            NominaDataGridView.Columns["marD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["marD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["marH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["marH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["mieD"].HeaderText = "Dia";
            NominaDataGridView.Columns["mieH"].HeaderText = "Extra";
            NominaDataGridView.Columns["mieD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["mieD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["mieH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["mieH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["jueD"].HeaderText = "Dia";
            NominaDataGridView.Columns["jueH"].HeaderText = "Extra";
            NominaDataGridView.Columns["jueD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["jueD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["jueH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["jueH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["vieD"].HeaderText = "Dia";
            NominaDataGridView.Columns["vieH"].HeaderText = "Extra";
            NominaDataGridView.Columns["vieD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["vieD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["vieH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["vieH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["sabD"].HeaderText = "Dia";
            NominaDataGridView.Columns["sabH"].HeaderText = "Extra";
            NominaDataGridView.Columns["sabD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["sabD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["sabH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["sabH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["domD"].HeaderText = "Dia";
            NominaDataGridView.Columns["domH"].HeaderText = "Extra";
            NominaDataGridView.Columns["domD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["domD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["domH"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["domH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            NominaDataGridView.Columns["totalD"].HeaderText = "Dias";
            NominaDataGridView.Columns["totalD"].ReadOnly = true;
            NominaDataGridView.Columns["totalD"].DefaultCellStyle.BackColor = Color.LightGray;
            NominaDataGridView.Columns["totalD"].DefaultCellStyle.Format = "N0";
            NominaDataGridView.Columns["totalH"].HeaderText = "Horas";
            NominaDataGridView.Columns["totalH"].ReadOnly = true;
            NominaDataGridView.Columns["totalH"].DefaultCellStyle.BackColor = Color.LightGray;
            NominaDataGridView.Columns["totalH"].DefaultCellStyle.Format = "N0";

            int i = 0;
            NominaDataGridView.Columns["anio"].DisplayIndex = i;
            NominaDataGridView.Columns["semana"].DisplayIndex = i++;
            NominaDataGridView.Columns["status"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_encargado"].DisplayIndex = i++;
            NominaDataGridView.Columns["caja"].DisplayIndex = i++;
            NominaDataGridView.Columns["nro_empleado"].DisplayIndex = i++;
            NominaDataGridView.Columns["trabajador"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_empleo"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_det"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_cab"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_empleado"].DisplayIndex = i++;            
            NominaDataGridView.Columns["valorD"].DisplayIndex = i++;
            NominaDataGridView.Columns["valorH"].DisplayIndex = i++;
            NominaDataGridView.Columns["lunD"].DisplayIndex = i++;
            NominaDataGridView.Columns["lunH"].DisplayIndex = i++;
            NominaDataGridView.Columns["marD"].DisplayIndex = i++;
            NominaDataGridView.Columns["marH"].DisplayIndex = i++;
            NominaDataGridView.Columns["mieD"].DisplayIndex = i++;
            NominaDataGridView.Columns["mieH"].DisplayIndex = i++;
            NominaDataGridView.Columns["jueD"].DisplayIndex = i++;
            NominaDataGridView.Columns["jueH"].DisplayIndex = i++;
            NominaDataGridView.Columns["vieD"].DisplayIndex = i++;
            NominaDataGridView.Columns["vieH"].DisplayIndex = i++;
            NominaDataGridView.Columns["sabD"].DisplayIndex = i++;
            NominaDataGridView.Columns["sabH"].DisplayIndex = i++;
            NominaDataGridView.Columns["domD"].DisplayIndex = i++;
            NominaDataGridView.Columns["domH"].DisplayIndex = i++;
            NominaDataGridView.Columns["totalD"].DisplayIndex = i++;
            NominaDataGridView.Columns["totalH"].DisplayIndex = i++;
            NominaDataGridView.Columns["pagado"].DisplayIndex = i++;

            NominaDataGridView.Columns["nro_empleado"].Width = 60;
            NominaDataGridView.Columns["caja"].Width = 60;
            NominaDataGridView.Columns["trabajador"].Width = 110;
            int valores = 50;
            NominaDataGridView.Columns["lunD"].Width = valores;
            NominaDataGridView.Columns["lunH"].Width = valores;
            NominaDataGridView.Columns["marD"].Width = valores;
            NominaDataGridView.Columns["marH"].Width = valores;
            NominaDataGridView.Columns["mieD"].Width = valores;
            NominaDataGridView.Columns["mieH"].Width = valores;
            NominaDataGridView.Columns["jueD"].Width = valores;
            NominaDataGridView.Columns["jueH"].Width = valores;
            NominaDataGridView.Columns["vieD"].Width = valores;
            NominaDataGridView.Columns["vieH"].Width = valores;
            NominaDataGridView.Columns["sabD"].Width = valores;
            NominaDataGridView.Columns["sabH"].Width = valores;
            NominaDataGridView.Columns["domD"].Width = valores;
            NominaDataGridView.Columns["domH"].Width = valores;
            NominaDataGridView.Columns["totalD"].Width = valores;
            NominaDataGridView.Columns["totalH"].Width = valores;
            NominaDataGridView.Columns["pagado"].Width = valores;
        }

        private void CalcularTotales(int rowIndex = -1)
        {
            if (rowIndex != -1)
            {
                vv_nominas item = nominas[rowIndex];
                int totalDias = Convert.ToInt32(item.lunD + item.marD + item.mieD + item.jueD + item.vieD + item.sabD + item.domD);
                int totalExtra = Convert.ToInt32(item.lunH + item.marH + item.mieH + item.jueH + item.vieH + item.sabH + item.domH);
                NominaDataGridView.Rows[rowIndex].Cells["totalD"].Value = totalDias;
                NominaDataGridView.Rows[rowIndex].Cells["totalH"].Value = totalExtra;
                LoadTotalesGrid();
                return;
            }

            int i = 0;
            foreach (vv_nominas item in nominas)
            {
                int totalDias = Convert.ToInt32(item.lunD + item.marD + item.mieD + item.jueD + item.vieD + item.sabD + item.domD);
                int totalExtra = Convert.ToInt32(item.lunH + item.marH + item.mieH + item.jueH + item.vieH + item.sabH + item.domH);
                NominaDataGridView.Rows[i].Cells["totalD"].Value = totalDias;
                NominaDataGridView.Rows[i].Cells["totalH"].Value = totalExtra;
                i++;
            }
            LoadTotalesGrid();
        }

        private void CancelarCambios()
        {
            EncargadoComboBox.ComboBox.SelectedIndex = -1;

            LimpiarNominaGrid();
            ModoEdicionNominaFalse();
        }

        private void DeshabilitarGrid()
        {
            NominaDataGridView.Columns["lunD"].ReadOnly = true;
            NominaDataGridView.Columns["lunH"].ReadOnly = true;
            NominaDataGridView.Columns["marD"].ReadOnly = true;
            NominaDataGridView.Columns["marH"].ReadOnly = true;
            NominaDataGridView.Columns["mieD"].ReadOnly = true;
            NominaDataGridView.Columns["mieH"].ReadOnly = true;
            NominaDataGridView.Columns["jueD"].ReadOnly = true;
            NominaDataGridView.Columns["jueH"].ReadOnly = true;
            NominaDataGridView.Columns["vieD"].ReadOnly = true;
            NominaDataGridView.Columns["vieH"].ReadOnly = true;
            NominaDataGridView.Columns["sabD"].ReadOnly = true;
            NominaDataGridView.Columns["sabH"].ReadOnly = true;
            NominaDataGridView.Columns["domD"].ReadOnly = true;
            NominaDataGridView.Columns["domH"].ReadOnly = true;

            NominaDataGridView.Columns["lunD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["lunH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["marD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["marH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["mieD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["mieH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["jueD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["jueH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["vieD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["vieH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["sabD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["sabH"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["domD"].DefaultCellStyle.BackColor  = Color.Gray;
            NominaDataGridView.Columns["domH"].DefaultCellStyle.BackColor  = Color.Gray;
        }

        private void HabilitarGrid()
        {
            NominaDataGridView.Columns["lunD"].ReadOnly = false;
            NominaDataGridView.Columns["lunH"].ReadOnly = false;
            NominaDataGridView.Columns["marD"].ReadOnly = false;
            NominaDataGridView.Columns["marH"].ReadOnly = false;
            NominaDataGridView.Columns["mieD"].ReadOnly = false;
            NominaDataGridView.Columns["mieH"].ReadOnly = false;
            NominaDataGridView.Columns["jueD"].ReadOnly = false;
            NominaDataGridView.Columns["jueH"].ReadOnly = false;
            NominaDataGridView.Columns["vieD"].ReadOnly = false;
            NominaDataGridView.Columns["vieH"].ReadOnly = false;
            NominaDataGridView.Columns["sabD"].ReadOnly = false;
            NominaDataGridView.Columns["sabH"].ReadOnly = false;
            NominaDataGridView.Columns["domD"].ReadOnly = false;
            NominaDataGridView.Columns["domH"].ReadOnly = false;

            NominaDataGridView.Columns["lunD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["lunH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["marD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["marH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["mieD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["mieH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["jueD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["jueH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["vieD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["vieH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["sabD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["sabH"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["domD"].DefaultCellStyle.BackColor  = Color.White;
            NominaDataGridView.Columns["domH"].DefaultCellStyle.BackColor  = Color.White;
        }

        private void ModoEdicionNominaTrue()
        { 
            SemanaComboBox.Enabled = false;
            AnioComboBox.Enabled = false;
            EncargadoComboBox.Enabled = false;
            CargarNominaToolStripButton.Enabled = false;

            GuardarToolStripButton.Enabled = true;
            CancelarToolStripButton.Enabled = true;
            CerrarNominaToolStripButton.Enabled = true;
        }

        private void ModoEdicionNominaFalse()
        {
            SemanaComboBox.Enabled = true;
            AnioComboBox.Enabled = true;
            EncargadoComboBox.Enabled = true;
            CargarNominaToolStripButton.Enabled = true;

            GuardarToolStripButton.Enabled = false;
            CancelarToolStripButton.Enabled = false;
            CerrarNominaToolStripButton.Enabled = false;
        }

        private void ModoNominaCerrada()
        {
            SemanaComboBox.Enabled = true;
            AnioComboBox.Enabled = true;
            EncargadoComboBox.Enabled = true;
            CargarNominaToolStripButton.Enabled = true;

            GuardarToolStripButton.Enabled = true;
            CancelarToolStripButton.Enabled = true;
            CerrarNominaToolStripButton.Enabled = false;

            EncargadoComboBox.SelectedIndex = -1;
        }

        private void LoadTotalesGrid()
        {
            try
            {
                List<TotalNomina> totalNomina = new List<TotalNomina>();
                List<Empleos> empleos = null;

                using (MazantinesEntities db = new MazantinesEntities())
                {
                    empleos = db.Empleos.ToList();
                }
                foreach (Empleos empleo in empleos)
                {
                    var empNomina = this.nominas.Where(n => n.id_empleo == empleo.Id).ToList();

                    double lunD = empNomina.Sum(f => (double)f.lunD);
                    double marD = empNomina.Sum(f => (double)f.marD);
                    double mieD = empNomina.Sum(f => (double)f.mieD);
                    double jueD = empNomina.Sum(f => (double)f.jueD);
                    double vieD = empNomina.Sum(f => (double)f.vieD);
                    double sabD = empNomina.Sum(f => (double)f.sabD);
                    double domD = empNomina.Sum(f => (double)f.domD);

                    double lunH = empNomina.Sum(f => (double)f.lunH);
                    double marH = empNomina.Sum(f => (double)f.marH);
                    double mieH = empNomina.Sum(f => (double)f.mieH);
                    double jueH = empNomina.Sum(f => (double)f.jueH);
                    double vieH = empNomina.Sum(f => (double)f.vieH);
                    double sabH = empNomina.Sum(f => (double)f.sabH);
                    double domH = empNomina.Sum(f => (double)f.domH);

                    double valorD = empNomina.Select(f => (double)f.valorD).FirstOrDefault();
                    double valorH = empNomina.Select(f => (double)f.valorH).FirstOrDefault();

                    TotalNomina miTotal = new TotalNomina
                    {
                        Empleo = empleo.Empleo,
                        Id_empleo = empleo.Id,
                        TotalDias = Convert.ToDouble(lunD + marD + mieD + jueD + vieD + sabD + domD),
                        TotalHoras = Convert.ToDouble(lunH + marH + mieH + jueH + vieH + sabH + domH),
                        valorDias = (decimal)valorD,
                        valorHoras = (decimal)valorH
                    };
                    totalNomina.Add(miTotal);
                }

                TotalesDataGridView.DataSource = totalNomina;

                TotalesDataGridView.Columns["id_empleo"].Visible = false;
                TotalesDataGridView.Columns["TotalDias"].HeaderText = "Dias";
                TotalesDataGridView.Columns["TotalDias"].DefaultCellStyle.Format = "N0";
                TotalesDataGridView.Columns["TotalDias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                TotalesDataGridView.Columns["TotalHoras"].HeaderText = "Horas";
                TotalesDataGridView.Columns["TotalHoras"].DefaultCellStyle.Format = "N0";
                TotalesDataGridView.Columns["TotalHoras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                TotalesDataGridView.Columns["valorDias"].HeaderText = "€ Dias";
                TotalesDataGridView.Columns["valorDias"].DefaultCellStyle.Format = "N2";
                TotalesDataGridView.Columns["valorDias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                TotalesDataGridView.Columns["valorHoras"].HeaderText = "€ Horas";
                TotalesDataGridView.Columns["valorHoras"].DefaultCellStyle.Format = "N2";
                TotalesDataGridView.Columns["valorHoras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                TotalesDataGridView.Columns["total"].DefaultCellStyle.Format = "N2";
                TotalesDataGridView.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                int pos = 0;
                TotalesDataGridView.Columns["Id_empleo"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["Empleo"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["TotalDias"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["valorDias"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["TotalHoras"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["valorHoras"].DisplayIndex = pos++;
                TotalesDataGridView.Columns["Total"].DisplayIndex = pos++;

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Constructors
        public FrmNomina()
        {
            InitializeComponent();
        } 
        #endregion

        private void FrmNomina_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void CargarNominaToolStripButton_Click(object sender, EventArgs e)
        {
            int semana = (int)SemanaComboBox.ComboBox.SelectedValue;
            int anio = (int)AnioComboBox.ComboBox.SelectedValue;

            int encargado = 0;
            if(EncargadoComboBox.ComboBox.SelectedValue != null)
            {
                encargado = (int)EncargadoComboBox.ComboBox.SelectedValue;
            }

            this.Enabled = false;
            CargarNomina(anio, semana, encargado);
            this.Enabled = true;
        }

        private void NominaDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (NominaDataGridView.Columns[e.ColumnIndex].ReadOnly == false && 
                NominaDataGridView.Columns[e.ColumnIndex].Visible == true &&
                NominaDataGridView.Columns[e.ColumnIndex].Name != "pagado") // 1 should be your column index
            {
                float i;

                if (!float.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        "Por favor ingrese un valor numérico válido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            if (nominas == null || nominas.Count <= 0) return;

            DialogResult result = MessageBox.Show(
                "Confirme guardar los cambios de la nómina actual",
                "Confirme el proceso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );
            if (result == DialogResult.No) return;

            GuardarNomina();
            ModoEdicionNominaFalse();
        }

        private void CerrarNominaToolStripButton_Click(object sender, EventArgs e)
        {
            if (nominas == null || nominas.Count <= 0) return;

            DialogResult result = MessageBox.Show(
                   "Confirme Cerrar la nómina actual. Este proceso no puede deshacerse",
                   "Confirme el proceso",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2
                   );
            if (result == DialogResult.No) return;

            CerrarNomina();
        }

        private void NominaDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales(e.RowIndex);
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(NominaDataGridView.RowCount == 0)
            {
                MessageBox.Show("No existen datos cargados para imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<rpt_nominas> rptNomina = null;
            using (MazantinesEntities db = new MazantinesEntities())
            {
                int id_cab = Convert.ToInt32(nominas[0].id_cab);
                rptNomina = db.rpt_nominas.Where(r => r.id_cab == id_cab).ToList();
            }

            this.Enabled = false;
            Reports.VistaPreliminarNomina(new RptNomina(), ToDataTable(rptNomina));
            this.Enabled = true;
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NominaDataGridView.RowCount == 0)
            {
                MessageBox.Show("No existen datos cargados para imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_cab = Convert.ToInt32(nominas[0].id_cab);
            DataTable dt = rpt_recibosTableAdapter1.GetDataByIdCab(id_cab);

            this.Enabled = false;
            Reports.VistaPreliminarNomina(new RptRecibos(), dt);
            this.Enabled = true;
        }

        private void NominaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NominaDataGridView.Columns[e.ColumnIndex].Name == "pagado" && NominaDataGridView.CurrentRow.Cells["status"].Value.ToString() == "A")
            {
                nominas[e.RowIndex].pagado = !(bool)NominaDataGridView.Rows[e.RowIndex].Cells["pagado"].Value;
            }
        }

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            CancelarCambios();
        }
    }
}
