using System;

namespace ManzantinesApp.Classes
{
    public class TotalNomina
    {
        public int Id_empleo { get; set; }
        public string Empleo { get; set; }
        public double TotalDias { get; set; }
        public double TotalHoras { get; set; }
        public decimal valorDias { get; set; }
        public decimal valorHoras { get; set; }
        public decimal Total {
            get {
                return Convert.ToDecimal((TotalDias * (double)valorDias) + ( TotalHoras * (double)valorHoras));
            }
        }
    }
}
