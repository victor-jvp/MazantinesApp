﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MazantinesEntities : DbContext
    {
        public MazantinesEntities()
            : base("name=MazantinesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Asientos> Asientos { get; set; }
        public virtual DbSet<Casas> Casas { get; set; }
        public virtual DbSet<DiasSemana> DiasSemana { get; set; }
        public virtual DbSet<Empleos> Empleos { get; set; }
        public virtual DbSet<EmpleosPagos> EmpleosPagos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Encargados> Encargados { get; set; }
        public virtual DbSet<Fincas> Fincas { get; set; }
        public virtual DbSet<Liquidaciones> Liquidaciones { get; set; }
        public virtual DbSet<NominasCab> NominasCab { get; set; }
        public virtual DbSet<NominasDet> NominasDet { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }
        public virtual DbSet<Trabajadores_Empleos> Trabajadores_Empleos { get; set; }
        public virtual DbSet<rpt_nominas> rpt_nominas { get; set; }
        public virtual DbSet<vv_CasasCountEmpleados> vv_CasasCountEmpleados { get; set; }
        public virtual DbSet<vv_empleados> vv_empleados { get; set; }
        public virtual DbSet<vv_EmpleadosCasas> vv_EmpleadosCasas { get; set; }
        public virtual DbSet<vv_nomina_trabajadores> vv_nomina_trabajadores { get; set; }
        public virtual DbSet<vv_nominas> vv_nominas { get; set; }
        public virtual DbSet<vv_table_asientos> vv_table_asientos { get; set; }
    }
}
