using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/// Funciones administrador 

public class DAO_Admin
{
    public List<E_rol> getRol()
    {
        using (var db = new Mapeo())
        {
            return db.rol.ToList();
        }
    }

    public List<E_ruta> getRuta()
    {
        using (var db = new Mapeo())
        {
            return db.ruta.ToList();
        }
    }

    public List<E_driver> getDriver()
    {
        using (var db = new Mapeo())
        {
            return db.driver.ToList();
        }
    }

    public List<E_user> getUserBeneficiario()
    {
        using (var db = new Mapeo())
        {
            return (from uu in db.usuario
                    join rol in db.rol on uu.Id_rol equals rol.Id

                    select new
                    {
                        uu,
                        rol
                    }).ToList().Select(m => new E_user
                    {
                        Id = m.uu.Id,
                        Name_rol = m.rol.Rol_name,
                        Name = m.uu.Name,
                        Last_name = m.uu.Last_name,
                        User = m.uu.User,
                        Pass = m.uu.Pass,
                        Pasaporte_numero = m.uu.Pasaporte_numero,
                        Activo = m.uu.Activo,
                        Qr_hash = m.uu.Qr_hash
                    }).ToList();
        }
    }

    public void addUser(E_user user)
    {
        using (var db = new Mapeo())
        {
            db.usuario.Add(user);
            db.SaveChanges();
        }
    }

    public void deleteUser(E_user user)
    {
        using (var db = new Mapeo())
        {
            db.usuario.Attach(user);
            var entry = db.Entry(user);
            entry.State = EntityState.Deleted;
            db.SaveChanges();
        }
    }


}