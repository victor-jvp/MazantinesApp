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
    
    public partial class Trabajadores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trabajadores()
        {
            this.NominasDet = new HashSet<NominasDet>();
            this.Trabajadores_Empleos = new HashSet<Trabajadores_Empleos>();
        }
    
        public int Id { get; set; }
        public string Nro_empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> id_empresa { get; set; }
        public Nullable<int> id_casa { get; set; }
        public string foto { get; set; }
        public byte[] foto2 { get; set; }
        public Nullable<int> id_encargado { get; set; }
        public string CCC { get; set; }
        public string Caja { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    
        public virtual Casas Casas { get; set; }
        public virtual Empresas Empresas { get; set; }
        public virtual Encargados Encargados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NominasDet> NominasDet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trabajadores_Empleos> Trabajadores_Empleos { get; set; }
    }
}
