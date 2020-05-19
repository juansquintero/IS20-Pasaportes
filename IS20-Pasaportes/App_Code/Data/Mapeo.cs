using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


/// Clase de configuracion de conexion con base de datos

public class Mapeo : DbContext
{
    static Mapeo()
    {
        Database.SetInitializer<Mapeo>(null);
    }
    private readonly string schema;
    public Mapeo() : base("name=Conexion")
    {

    }
    //---------------------------------------//
    public DbSet<E_user>usuario { get; set; }
    public DbSet<E_rol> rol { get; set; }
    public DbSet<E_ruta> ruta { get; set; }
    public DbSet<E_driver> driver { get; set; }
    public DbSet<E_reunion> reunion { get; set;}
    public DbSet<E_Auth> autentication { get; set; }
    public DbSet<E_cambioPasaportes> cambioPasaportes { get; set; }
    public DbSet<E_reportes> reportes { get; set; }
    //---------------------------------------//
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(this.schema);
        base.OnModelCreating(modelBuilder);
    }
}