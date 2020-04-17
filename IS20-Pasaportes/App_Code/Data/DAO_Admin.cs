using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAO_Admin
/// </summary>
public class DAO_Admin
{
    public List<E_rol> getRol()
    {
        using (var db = new Mapeo())
        {
            return db.rol.ToList();
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
}