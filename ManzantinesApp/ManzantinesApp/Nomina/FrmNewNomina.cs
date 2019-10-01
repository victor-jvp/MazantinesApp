namespace ManzantinesApp.Nomina
{
    using ManzantinesApp.Classes;
    using System;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    public partial class FrmNewNomina : Form
    {
        private void LoadCombos()
        {
            AnioComboBox.DataSource = Anios.GetAnios(DateTime.Now.Year);
            AnioComboBox.DisplayMember = "Value";
            AnioComboBox.ValueMember = "Value";
            AnioComboBox.SelectedValue = DateTime.Now.Year;

            SemanaComboBox.DataSource = Semanas.GetSemanas(DateTime.Now.Year);
            SemanaComboBox.DisplayMember = "Value";
            SemanaComboBox.ValueMember = "Value";
            SemanaComboBox.SelectedValue = GetWeekNumber();

            EncargadoComboBox.DataSource = encargadosTableAdapter.GetData();
            EncargadoComboBox.DisplayMember = "Encargado";
            EncargadoComboBox.ValueMember = "Id";
            EncargadoComboBox.SelectedIndex = -1;
        }

        private int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public FrmNewNomina()
        {
            InitializeComponent();
        }

        private void FrmNewNomina_Load(object sender, EventArgs e)
        {
            LoadCombos();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show(
                "Confirmar nueva nomina",
                "Validar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    int anio = (int)AnioComboBox.SelectedValue;
                    int semana = (int)SemanaComboBox.SelectedValue;
                    var encargado = 0;
                    if (!string.IsNullOrEmpty(EncargadoComboBox.Text) && EncargadoComboBox.SelectedValue != null)
                    {
                        encargado = (int)EncargadoComboBox.SelectedValue;
                    }

                    if (FaltantesRadioButton.Checked)
                    {
                        using (var db = new ManzantinesApp.DBContext.MazantinesEntities())
                        {
                            var trabajadores = db.vv_nomina_trabajadores.ToList();
                            bool doNomina = false;
                            foreach (var trabajador in trabajadores)
                            {
                                int inNomina = db.vv_nominas.Where(n => n.anio == anio && n.semana == semana && n.id_empleado == trabajador.id).Count();
                                if (inNomina <= 0)
                                {
                                    doNomina = true;
                                }
                            }
                            if (!doNomina) {
                                MessageBox.Show("No existen trabajadores sin nomina para el año y semana seleccionados.",
                                    "Atención",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                    }                    

                    FrmNomina miNomina = new FrmNomina();
                    miNomina.anio = anio;
                    miNomina.semana = semana;
                    if (!string.IsNullOrEmpty(EncargadoComboBox.Text) && EncargadoComboBox.SelectedValue != null)
                    {
                        miNomina.encargado = encargado;
                    }
                    if (FaltantesRadioButton.Checked)
                    {
                        miNomina.trabajadoresFaltantes = true;
                    }

                    this.Hide();
                    miNomina.ShowDialog(this.Parent);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
