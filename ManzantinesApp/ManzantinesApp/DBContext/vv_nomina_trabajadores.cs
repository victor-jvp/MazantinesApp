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
    
    public partial class vv_nomina_trabajadores
    {
        public int id { get; set; }
        public string Nro_empleado { get; set; }
        public Nullable<int> caja { get; set; }
        public string trabajador { get; set; }
        public Nullable<int> id_encargado { get; set; }
        public Nullable<int> id_empleo { get; set; }
        public double valorD { get; set; }
        public double valorH { get; set; }
    }
}
