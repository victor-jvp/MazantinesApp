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
    
    public partial class Casas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casas()
        {
            this.Trabajadores = new HashSet<Trabajadores>();
        }
    
        public int Id { get; set; }
        public int NroCasa { get; set; }
        public Nullable<int> id_finca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trabajadores> Trabajadores { get; set; }
        public virtual Fincas Fincas { get; set; }
    }
}
