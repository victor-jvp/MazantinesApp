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
        private void Inicializar()
        {
            var anio = DateTime.Now.Year;

            LoadCombos(anio);

            NominaDataGridView.DataSource = null;

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
                    nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana).ToList();
                }

                if(nominas == null || nominas.Count <= 0)
                {
                    //Cargar una nueva nomina
                    if(encargado == 0)
                    {
                        List<vv_nomina_trabajadores> trabajadores = null;
                        using (MazantinesEntities db = new MazantinesEntities())
                        {
                            trabajadores = db.vv_nomina_trabajadores.ToList();

                            if(trabajadores.Count == 0)
                            {
                                MessageBox.Show(
                                    "No existen trabajadores registrados.", 
                                    "Error en carga de Nómina", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                                return;
                            }

                            NominasCab cab = new NominasCab()
                            {
                                semana = semana,
                                anio = anio,
                                status = "A"
                            };
                            
                            foreach (vv_nomina_trabajadores row in trabajadores)
                            {
                                cab.NominasDet.Add(new NominasDet
                                {
                                    id_empleado = row.id,
                                    lunD = 1, lunH = 0,
                                    marD = 1, marH = 0,
                                    mieD = 1, mieH = 0,
                                    jueD = 1, jueH = 0,
                                    vieD = 1, vieH = 0,
                                    sabD = 1, sabH = 0,
                                    domD = 1, domH = 0,
                                    valorD = row.valorD, valorH = row.valorH
                                });
                            }
                            db.NominasCab.Add(cab);
                            db.SaveChanges();
                        } 
                    }
                }

                using (MazantinesEntities db = new MazantinesEntities())
                {
                    nominas = db.vv_nominas.Where(f => f.anio == anio && f.semana == semana).ToList();
                }

                //Validar si la nomina esta cerrada
                if (nominas[0].status == "C")
                {
                    MessageBox.Show(
                        "La Nomina seleccionada esta Cerrada, no es posible modificar.",
                        "Nomina Cerrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    DeshabilitarGrid();
                }
                else
                {
                    HabilitarGrid();
                }

                NominaDataGridView.DataSource = null;
                NominaDataGridView.DataSource = nominas;
                CalcularTotales();
                FormatColumns();
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
                        db.NominasDet.Add(miNomina);
                        db.Entry(miNomina).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Guardar Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Cerrar Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void FormatColumns()
        {
            int i = 0;
            NominaDataGridView.Columns["anio"].DisplayIndex = i;
            NominaDataGridView.Columns["status"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_encargado"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_empleado"].DisplayIndex = i++;
            NominaDataGridView.Columns["nro_empleado"].DisplayIndex = i++;
            NominaDataGridView.Columns["empleado"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_cab"].DisplayIndex = i++;
            NominaDataGridView.Columns["id_det"].DisplayIndex = i++;
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
                    var rowNom = this.nominas.Where(n => n.id_empleo == empleo.Id).FirstOrDefault();

                    if(rowNom != null)
                    {
                        TotalNomina miTotal = new TotalNomina {
                            Empleo = empleo.Empleo,
                            Id_empleo = empleo.Id,
                            TotalDias = Convert.ToDouble(rowNom.lunD + rowNom.marD + rowNom.mieD + rowNom.jueD + rowNom.vieD + rowNom.sabD + rowNom.domD),
                            TotalHoras = Convert.ToDouble(rowNom.lunH + rowNom.marH + rowNom.mieH + rowNom.jueH + rowNom.vieH + rowNom.sabH + rowNom.domH),
                            valorDias = (decimal)rowNom.valorD,
                            valorHoras = (decimal)rowNom.valorH
                        };
                        totalNomina.Add(miTotal);
                    }
                }
                TotalesDataGridView.DataSource = totalNomina;
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
            if (NominaDataGridView.Columns[e.ColumnIndex].ReadOnly == false) // 1 should be your column index
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
            this.Enabled = false;
            Reports.VistaPreliminar(new RptNomina(), ToDataTable(this.nominas));
            this.Enabled = true;
        }

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
    }
}
