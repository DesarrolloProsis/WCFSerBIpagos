﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSerBIpagos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GTDBEntities : DbContext
    {
        public GTDBEntities()
            : base("name=GTDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CortesCajeroes> CortesCajeroes { get; set; }
        public virtual DbSet<CuentasTelepeajes> CuentasTelepeajes { get; set; }
        public virtual DbSet<Historico> Historico { get; set; }
        public virtual DbSet<ListaNegra> ListaNegra { get; set; }
        public virtual DbSet<MontosRecargables> MontosRecargables { get; set; }
        public virtual DbSet<OperacionesCajeroes> OperacionesCajeroes { get; set; }
        public virtual DbSet<OperacionesSerBIpagos> OperacionesSerBIpagos { get; set; }
        public virtual DbSet<Parametrizables> Parametrizables { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
    }
}
