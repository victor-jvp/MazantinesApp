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
    
    public partial class vv_EmpleadosCasas
    {
        public int id_casa { get; set; }
        public string Finca { get; set; }
        public int NroCasa { get; set; }
        public int id_trabajador { get; set; }
        public Nullable<int> Nro_empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Empresa { get; set; }
    }
}
