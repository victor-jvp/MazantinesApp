namespace ManzantinesApp.Nomina
{
    using ManzantinesApp.Classes;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class FrmNomina : Form
    {

        #region Properties

        List<Nomina> listNomina = null;

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

        public int GetWeekNumber()
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
                //int aux = nominasTableAdapter1.GetDataByAnioSemEmp();

                Data.RptDataSet.vv_nomina_trabajadoresDataTable misTrabajadores = null;

                if (encargado <= 0)
                {
                    misTrabajadores = vv_nomina_trabajadoresTableAdapter1.GetData();
                }
                else
                {
                    misTrabajadores = vv_nomina_trabajadoresTableAdapter1.GetDataByIdEncargado(encargado);
                }

                listNomina = new List<Nomina>();

                foreach (Data.RptDataSet.vv_nomina_trabajadoresRow miTrabajador in misTrabajadores.Rows)
                {
                    Data.DataSet1.NominasDataTable misConceptos = nominasTableAdapter1.GetDataByAnioSemEmp(anio, semana, miTrabajador.id);

                    Nomina miNomina = new Nomina()
                    {
                        Anio = anio,
                        Semana = semana,
                        Empleado = miTrabajador.trabajador,
                        id_empleado = miTrabajador.id,
                        Nro_empleado = miTrabajador.Nro_empleado
                    };

                    foreach (Data.DataSet1.NominasRow concepto in misConceptos.Rows)
                    {
                        miNomina.id = concepto.Id;
                        switch (concepto.diaSemana)
                        {
                            case "L":
                                if (concepto._base == "d") miNomina.LunesDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.LunesExtra = (float)concepto.valor;
                                break;
                            case "M":
                                if (concepto._base == "d") miNomina.MartesDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.MartesExtra = (float)concepto.valor;
                                break;
                            case "X":
                                if (concepto._base == "d") miNomina.MiercolesDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.MiercolesExtra = (float)concepto.valor;
                                break;
                            case "J":
                                if (concepto._base == "d") miNomina.JuevesDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.JuevesExtra = (float)concepto.valor;
                                break;
                            case "V":
                                if (concepto._base == "d") miNomina.ViernesDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.ViernesExtra = (float)concepto.valor;
                                break;
                            case "S":
                                if (concepto._base == "d") miNomina.SabadoDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.SabadoExtra = (float)concepto.valor;
                                break;
                            case "D":
                                if (concepto._base == "d") miNomina.DomingoDia = (float)concepto.valor;
                                if (concepto._base == "h") miNomina.DomingoExtra = (float)concepto.valor;
                                break;
                            default:
                                break;
                        }
                    }

                    listNomina.Add(miNomina);
                }

                NominaDataGridView.DataSource = listNomina;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en carga de Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int encargado = (int)EncargadoComboBox.ComboBox.SelectedValue;

            this.Enabled = false;
            CargarNomina(anio, semana, encargado);
            this.Enabled = true;
        }

        private void NominaDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex > 5) // 1 should be your column index
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
                else
                {
                        CalcularTotales(e.RowIndex);
                }
            }
        }

        private void CalcularTotales(int rowIndex)
        {
            int totalDias = (int)listNomina[rowIndex].totalDia;
            int totalExtra = (int)listNomina[rowIndex].totalExtra;

            NominaDataGridView.Rows[rowIndex].Cells["TotalDia"].Value = totalDias;
            NominaDataGridView.Rows[rowIndex].Cells["TotalExtra"].Value = totalExtra;
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Nomina nomina in listNomina)
                {
                    if (nomina.id == null)
                    {
                        //Insertar nuevo registro
                        this.nominasTableAdapter1.Insert(
                            nomina.Anio,
                            nomina.Semana,
                            nomina.id_empleado,
                            "L",
                            "D",
                            nomina.LunesDia,
                            3
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en carga de Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
