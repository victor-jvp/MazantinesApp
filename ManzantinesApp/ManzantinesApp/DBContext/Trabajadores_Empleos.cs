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
    
    public partial class Trabajadores_Empleos
    {
        public int Id { get; set; }
        public Nullable<int> id_trabajador { get; set; }
        public Nullable<int> id_empleo { get; set; }
    
        public virtual Empleos Empleos { get; set; }
        public virtual Trabajadores Trabajadores { get; set; }
    }
}
