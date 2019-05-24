namespace ManzantinesApp.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Nomina
    {
        #region Properties

        public int? cab_id { get; set; }
        public int? det_id { get; set; }
        public int Semana { get; set; }
        public int Anio { get; set; }
        public int id_empleado { get; set; }
        public string Nro_empleado { get; set; }
        public string Empleado { get; set; }
        public float LunesDia { get; set; }
        public float LunesExtra { get; set; }
        public float MartesDia { get; set; }
        public float MartesExtra { get; set; }
        public float MiercolesDia { get; set; }
        public float MiercolesExtra { get; set; }
        public float JuevesDia { get; set; }
        public float JuevesExtra { get; set; }
        public float ViernesDia { get; set; }
        public float ViernesExtra { get; set; }
        public float SabadoDia { get; set; }
        public float SabadoExtra { get; set; }
        public float DomingoDia { get; set; }
        public float DomingoExtra { get; set; }
        public float totalDia {
            get { return LunesDia + MartesDia + MiercolesDia + JuevesDia + ViernesDia + SabadoDia + DomingoDia; }
        }
        public float totalExtra {
            get { return LunesExtra + MartesExtra + MiercolesExtra + JuevesExtra + ViernesExtra + SabadoExtra + DomingoExtra; }
        }
        public string Status { get; set; }
        #endregion
    }
}
