﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class TrabajoConexion : DbContext
    {
        public TrabajoConexion()
            : base("name=TrabajoConexion")
        {
            //Por defecto estas propiedades están en tru
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CategoriasTrabajos> CategoriasTrabajos { get; set; }
        public virtual DbSet<TipoContratoes> TipoContratoes { get; set; }
        public virtual DbSet<TablaTrabajos> TablaTrabajos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries().Where(x => x.State == (EntityState)System.Data.Entity.EntityState.Added))
            {
                entry.Property("FechaRegistro").CurrentValue = DateTime.Now;
                entry.Property("FechaModificacion").CurrentValue = DateTime.Now;
                entry.Property("Estado").CurrentValue = true;
            }

            return base.SaveChanges();
        }
    }
}
