//------------------------------------------------------------------------------
// <auto-generated>
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
    
    public partial class rpt_recibos
    {
        public string Empresa { get; set; }
        public string Nro_empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int id_cab { get; set; }
        public Nullable<decimal> anio { get; set; }
        public Nullable<decimal> semana { get; set; }
        public Nullable<int> id_encargado { get; set; }
        public Nullable<System.DateTime> semanaIni { get; set; }
        public Nullable<System.DateTime> semanaFin { get; set; }
        public Nullable<double> totalD { get; set; }
        public Nullable<double> totalH { get; set; }
        public Nullable<double> valorD { get; set; }
        public Nullable<double> valorH { get; set; }
        public string caja { get; set; }
        public Nullable<double> importe { get; set; }
    }
}
