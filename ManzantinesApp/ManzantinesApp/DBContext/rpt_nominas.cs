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
    
    public partial class rpt_nominas
    {
        public Nullable<decimal> anio { get; set; }
        public Nullable<decimal> semana { get; set; }
        public string status { get; set; }
        public Nullable<int> id_encargado { get; set; }
        public string Encargado { get; set; }
        public string Nro_empleado { get; set; }
        public string Trabajador { get; set; }
        public string ccc { get; set; }
        public string Empresa { get; set; }
        public Nullable<int> id_empleo { get; set; }
        public int id_det { get; set; }
        public Nullable<int> id_cab { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public Nullable<double> valorD { get; set; }
        public Nullable<double> valorH { get; set; }
        public Nullable<double> lunD { get; set; }
        public Nullable<double> lunH { get; set; }
        public Nullable<double> marD { get; set; }
        public Nullable<double> marH { get; set; }
        public Nullable<double> mieD { get; set; }
        public Nullable<double> mieH { get; set; }
        public Nullable<double> jueD { get; set; }
        public Nullable<double> jueH { get; set; }
        public Nullable<double> vieD { get; set; }
        public Nullable<double> vieH { get; set; }
        public Nullable<double> sabD { get; set; }
        public Nullable<double> sabH { get; set; }
        public Nullable<double> domD { get; set; }
        public Nullable<double> domH { get; set; }
        public Nullable<bool> pagado { get; set; }
        public string caja { get; set; }
    }
}
