using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAO_Security
/// </summary>
public class DAO_Security
{
    public DAO_Security()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void insertAuthetication(E_Auth autentication)
    {
        using (var db = new Mapeo())
        {
            db.autentication.Add(autentication);
            db.SaveChanges();
        }
    }

    public void updateUser(E_Auth authenticate)
    {
        using (var db = new Mapeo())
        {
            E_Auth auth = new E_Auth();
            auth = db.autentication.Where(x => x.Session == authenticate.Session && x.User_id == authenticate.User_id).First();
            auth.fecha_Fin = DateTime.Now;
            db.autentication.Attach(auth);
            var entry = db.Entry(auth);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}