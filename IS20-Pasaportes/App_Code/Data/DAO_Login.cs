using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAO_Login
/// </summary>
public class DAO_Login
{
    public E_user Login(E_user user)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.User.Equals(user.User) && x.Pass.Equals(user.Pass)).FirstOrDefault();
        }
    }

    public E_user QR(E_user user)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Qr_hash.Equals(user.Qr_hash)).FirstOrDefault();
        }
    }
}