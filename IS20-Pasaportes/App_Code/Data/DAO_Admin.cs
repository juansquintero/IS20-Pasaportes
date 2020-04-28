using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QRCoder;
using System.IO;
using System.Drawing;

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
                    join rol in db.rol on uu.Id_rol equals 2

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
                        User_name = m.uu.User_name,
                        Pass = m.uu.Pass,
                        Pasaporte_numero = m.uu.Pasaporte_numero,
                        Id_ruta = m.uu.Id_ruta,
                        Mail = m.uu.Mail,
                        Name_ruta = m.uu.Name_ruta,
                        Activo = m.uu.Activo,
                        Id_rol = m.uu.Id_rol
                    }).ToList();
        }
    }

    public List<E_user> getUserDriver()
    {
        using (var db = new Mapeo())
        {
            return (from uu in db.usuario
                    join rol in db.rol on uu.Id_rol equals 3

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
                        User_name = m.uu.User_name,
                        Pass = m.uu.Pass,
                        Driver_total_pasaporte = m.uu.Driver_total_pasaporte,
                        Id_ruta = m.uu.Id_ruta,
                        Name_ruta = m.uu.Name_ruta,
                        Id_driver = m.uu.Id_driver,
                        Mail = m.uu.Mail,
                        Id_rol = m.uu.Id_rol
                    }).ToList();
        }
    }

    public List<E_user> getUserAdmin()
    {
        using (var db = new Mapeo())
        {
            return (from uu in db.usuario
                    join rol in db.rol on uu.Id_rol equals 1

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
                        User_name = m.uu.User_name,
                        Pass = m.uu.Pass,
                        Mail = m.uu.Mail,
                        Id_rol = m.uu.Id_rol                        
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

    public void deleteUser(E_user e_user)
    {
        using (var db = new Mapeo())
        {
            db.usuario.Attach(e_user);
            var entry = db.Entry(e_user);
            entry.State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
    
    public void editUser(E_user e_user)
    {
        using (var db = new Mapeo())
        {
            E_user e_user2 = db.usuario.Where(x => x.Id == e_user.Id).First();
            e_user2.Name = e_user.Name;
            e_user2.Last_name = e_user.Last_name;
            e_user2.User_name = e_user.User_name;
            e_user2.Pass = e_user.Pass;
            e_user2.Pasaporte_numero = e_user.Pasaporte_numero;
            e_user2.Activo = e_user.Activo;
            e_user2.Id_driver = e_user.Id_driver;
            e_user2.Mail = e_user.Mail;
            e_user2.LastModified = DateTime.Now;
            e_user2.Token = e_user.Token;
            e_user2.State_Id = e_user.State_Id;
            e_user2.EndToken = e_user.EndToken;
            e_user2.Sesion = e_user.Sesion;

            db.usuario.Attach(e_user2);
            var entry = db.Entry(e_user2);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public E_user getQrUser(string qr)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Qr_hash.Equals(qr)).FirstOrDefault();
        }
    }

    public E_user getMailUser(string mail)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Mail.Equals(mail)).FirstOrDefault();
        }
    }

    public E_user getTokenUser(string token)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Token.Equals(token)).FirstOrDefault();
        }
    }

    public E_user getUserLogin(string user)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.User_name.Equals(user)).FirstOrDefault();
        }
    }
}