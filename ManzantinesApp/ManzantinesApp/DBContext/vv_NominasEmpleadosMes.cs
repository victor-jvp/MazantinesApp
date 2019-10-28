//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManzantinesApp.DBContext
{
    using System;
    using System.Collections.Generic;

    public partial class vv_NominasEmpleadosMes
    {
        public int anio { get; set; }
        public int semana { get; set; }
        public Nullable<int> id_encargado { get; set; }
        public string Encargado { get; set; }
        public string Nro_Empleado { get; set; }
        public string Caja { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime semanaIni { get; set; }
        public DateTime semanaFin { get; set; }
        public int mesIni { get; set; }
        public int totalD { get; set; }
        public double totalH { get; set; }
        public int valorD { get; set; }
        public double valorH { get; set; }
        public double TotalPago { get; set; }
    }
}
